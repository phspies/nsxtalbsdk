using CaseExtensions;
using Nustache.Core;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using NSwag;
using NJsonSchema;
using NJsonSchema.References;
using System.Net;
using System.Web;
using System.Text;
using NSwag.Collections;
using System.Linq;
using System.Collections;
namespace nsxtapi
{
    class Program
    {
        static string projectDirectory = @"C:\Users\Phillip\source\repos\nsxtalbsdk\nsxtalbsdk";
        static string generatorDirectory = @"C:\Users\Phillip\source\repos\nsxtalbsdk\SDKGenerator";
        static string templatesDirectory = @"C:\Users\Phillip\source\repos\nsxtalbsdk\SDKGenerator\Templates";
        static string swaggerFilesDirectory = @"C:\Users\Phillip\source\repos\nsxtalbsdk\SDKGenerator\swagger";
        static void Main(string[] args)
        {
            Helpers.Register(nameof(ToXmlDoc), ToXmlDoc);
            Helpers.Register(nameof(GetMethodName), GetMethodName);
            Helpers.Register(nameof(GetDotNetName), GetDotNetName);
            Helpers.Register(nameof(GetDotNetType), GetDotNetType);
            Helpers.Register(nameof(GetOperationPathParams), GetOperationPathParams);
            Helpers.Register(nameof(GetOperationPathInjectionCode), GetOperationPathInjectionCode);
            Helpers.Register(nameof(GetOperationHttpMethod), GetOperationHttpMethod);
            Helpers.Register(nameof(GetOperationReturnType), GetOperationReturnType);
            Helpers.Register(nameof(GetResponseType), GetResponseType);
            Helpers.Register(nameof(GetPSValueDefinition), GetPSValueDefinition);
            Helpers.Register(nameof(GetResponseTypeName), GetResponseTypeName);
            Helpers.Register(nameof(GetPSVerb), GetPSVerb);
            Helpers.Register(nameof(GetBool), GetBool);
            Helpers.Register(nameof(GetTuple), GetTuple);
            Helpers.Register(nameof(GetLowerCase), GetLowerCase);
            Helpers.Register(nameof(GetCmdLetReturnCode), GetCmdLetReturnCode);
            Helpers.Register(nameof(GetServiceUrl), GetServiceUrl);
            Helpers.Register(nameof(GetResponseName), GetResponseName);
            Helpers.Register(nameof(GetParameterPascalCase), GetParameterPascalCase);
            Helpers.Register(nameof(SetDefaultValue), SetDefaultValue);
            Helpers.Register(nameof(GetRequiredLine), GetRequiredLine);
            Helpers.Register(nameof(GetEvaulateResponse), GetEvaulateResponse);
            List<apiSpecification> modules = new List<apiSpecification>();
            List<string> swaggerFiles = Directory.GetFiles(swaggerFilesDirectory, "*.json").ToList();
            swaggerFiles.ForEach(file =>
            {
                apiSpecification spec = new apiSpecification() { Name = PascalCase(Path.GetFileNameWithoutExtension(file)), ApiDocument = OpenApiDocument.FromFileAsync(file).Result };
                JsonSchemaReferenceUtilities.UpdateSchemaReferencePaths(spec.ApiDocument);
                modules.Add(spec);
            });
            Directory.CreateDirectory(Path.Combine(projectDirectory, "Models"));
            Directory.CreateDirectory(Path.Combine(projectDirectory, "Models", "Enums"));
            Directory.CreateDirectory(Path.Combine(projectDirectory, "Modules"));
            //Generate root api objects
            Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "RootModule.cs.template"), new
            {
                rootURL = modules.First().ApiDocument.BaseUrl,
                modules = modules.Select(x => x.Name),
            }, Path.Combine(projectDirectory, $"NSXTALBClient.cs"));
            modules.ForEach(module =>
            {
                Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "Module.cs.template"), new
                {
                    module = module.Name,
                    operations = module.ApiDocument.Operations,
                }, Path.Combine(projectDirectory, "Modules", $"{module.Name}.cs"));
            });
            modules.ForEach(module =>
            {
                module.ApiDocument.Definitions.ToList().ForEach(def =>
                {
                    var clz = def.Key;
                    Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "Model.cs.template"), new
                    {
                        clz,
                        module = module,
                        def = def.Value,
                        properties = def.Value.Properties.Values,
                    }, Path.Combine(projectDirectory, "Models", $"NSXTALB{clz}Type.cs"));
                    foreach (var prop in def.Value.Properties)
                    {
                        if (prop.Value.Enumeration.Count > 0)
                        {
                            EnumType currentEnum = new EnumType();
                            currentEnum.EnumName = PascalCase($"NSXTALB {clz} {prop.Key} enum type"); ;
                            currentEnum.Description = prop.Value.Description;
                            foreach (var enumValue in prop.Value.Enumeration)
                            {
                                int index = 1;
                                if (currentEnum.Values.Count > 0)
                                {
                                    index = (string)prop.Value.Default == (string)enumValue ? 0 : currentEnum.Values.Last().EnumIndex + 1;
                                }
                                currentEnum.Values.Add(new EnumValueType() { EnumValue = PascalCase(enumValue as string), JsonEnumValue = (enumValue as string).Replace(" ", "_").ToUpper(), EnumIndex = index });
                            }
                            Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "EnumModel.cs.template"), new
                            {
                                currentEnum
                            }, Path.Combine(projectDirectory, "Models", "Enums", $"NSXTALB{currentEnum.EnumName}.cs"));
                        }
                    }
                });
            });
        }
        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return "";
            }
            if (value is System.Enum)
            {
                var name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value != null ? attribute.Value : name;
                        }
                    }
                    var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                    return converted == null ? string.Empty : converted;
                }
            }
            else if (value is bool)
            {
                return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[])value);
            }
            else if (value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }
            var result = System.Convert.ToString(value, cultureInfo);
            return result == null ? "" : result;
        }
        private static void GetEvaulateResponse(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            int code = int.Parse((string)((DictionaryEntry)arguments[0]).Key);
            OpenApiResponse response = (OpenApiResponse)((DictionaryEntry)arguments[0]).Value;
            if (!(200 <= code && code <= 300))
            {
                context.Write("else if ((int)response.StatusCode == " + code + ") { throw new NSXTALBException(" + $"\"{response.Description}\"" + ", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }");
            }
            else
            {
                context.Write("if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }");
            }
        }
        private static void GetServiceUrl(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var path = ((OpenApiOperationDescription)arguments[0]);
            context.Write($"{path.Operation.Parent.Parent.BasePath}{path.Path}");
        }
        private static void SetDefaultValue(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            //var (method, operation) = ((KeyValuePair<string, OpenApiPathItem>)arguments[0]);
            context.Write($"test");
        }
        private static void GetCmdLetReturnCode(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var parameter = (OpenApiParameter)arguments[0];
            context.Write($"{GetDotNetType(parameter)} {PascalCase(parameter.Name)}");
        }
        private static void GetParameterPascalCase(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var parameter = (string)arguments[0];
            context.Write($"{PascalCase(parameter)}");
        }
        private static void GetPSValueDefinition(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var parameter = (OpenApiParameter)arguments[0];
            context.Write($"{GetDotNetType(parameter)} {PascalCase(parameter.Name)}");
        }
        private static void GetPSVerb(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var (method, operation) = (KeyValuePair<string, OpenApiOperation>)arguments[0];
            string module = arguments[1] as string;
            List<string> list = StringSplitter(operation.OperationId);
            context.Write($"\"{list[0]}\",\"{module}{PascalCase(string.Join("", list.GetRange(1, list.Count - 1)))}\"");
        }
        private static void GetResponseTypeName(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var response = (OpenApiResponse)arguments[0];
            context.Write($"NSXALBT{((IJsonReferenceBase)response.Schema).ReferencePath.Split("/")[3]}Type");
        }
        private static void ToXmlDoc(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is string)
            {
                var first = true;
                using (var reader = new StringReader(arguments[0] as string))
                {
                    string line = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (arguments.Count > 1 && arguments[1] as string == "wrap")
                        {
                            foreach (var wline in WordWrap(line, 120))
                            {
                                if (!first)
                                {
                                    context.Write("\r\n        /// ");
                                }
                                else
                                {
                                    first = false;
                                }
                                context.Write(HttpUtility.HtmlDecode(wline));
                            }
                        }
                        else
                        {
                            context.Write(SecurityElement.Escape(line.Replace("\n", "").Replace("\r", "")));
                        }
                    }
                }
            }
        }
        private static void GetRequiredLine(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var param = ((OpenApiParameter)arguments[0]);
            if (param.IsRequired)
            {
                if (PascalCase(param.Name) == "XAviVersion")
                {
                    context.Write("if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }");
                }
                else
                {
                    context.Write($"if (" + PascalCase(param.Name) + " == null) {" + " throw new ArgumentNullException(\"" + PascalCase(param.Name) + " cannot be null\"); }");
                }
            }
        }
        private static void GetOperationPathParams(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var operation = ((OpenApiOperationDescription)arguments[0]).Operation;
            List<string> returnList = new();
            var operations = operation.Parameters.OrderByDescending(x => x.IsRequired).ToList();
            if (operations.Any(x => x.Name == "X-Avi-Version"))
            {
                int versionIndex = operations.IndexOf(operations.First(x => x.Name == "X-Avi-Version"));
                var verionobject = operations[versionIndex];
                operations.RemoveAt(versionIndex);
                operations.Add(verionobject);
            }
            foreach (var parameter in operations)
            {
                if (parameter.Name.ToLower() == "X-Avi-Version".ToLower())
                {
                    returnList.Add($"{GetDotNetType(parameter)}? {PascalCase(parameter.Name)} = null");
                }
                else
                {
                    returnList.Add($"{GetDotNetType(parameter)} {PascalCase(parameter.Name)}" + (parameter.IsRequired ? "" : " = null"));
                }
            }
            context.Write(string.Join(", ", returnList));
        }
        private static void GetOperationReturnType(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var operation = ((OpenApiOperationDescription)arguments[0]).Operation;
            var response = operation.Responses.FirstOrDefault(x => x.Key.StartsWith("20"));
            if (response.Value.Schema != null)
            {
                if (response.Value.Schema?.Reference != null)
                {
                    string className = $"NSXTALB{((IJsonReferenceBase)response.Value.Schema).ReferencePath.Split("/")[3]}Type";
                    if (arguments[1] as string == "full")
                    {
                        context.Write($"{className}");
                    }
                    else if (arguments[1] as string == "bare")
                    {
                        context.Write(className);
                    }
                    else if (arguments[1] as string == "init")
                    {
                        context.Write($"{className}? returnValue = default({className});");
                    }
                    else if (arguments[1] as string == "cast")
                    {
                        context.Write($"returnValue = JsonConvert.DeserializeObject<{className}>(response.Content, defaultSerializationSettings);");
                    }
                    else if (arguments[1] as string == "return")
                    {
                        var okResponse = operation.Responses.FirstOrDefault(x => x.Key.StartsWith("20"));
                        if (okResponse.Value.Schema != null)
                        {
                            context.Write("return response.Data;");
                        }
                    }
                    else if (arguments[1] as string == "cmdlet")
                    {
                        context.Write($"[OutputType(typeof({className}))]");
                    }
                    else if (arguments[1] as string == "cmdletreturn")
                    {
                        string module = arguments[2] as string;
                        string operationId = operation.OperationId;
                        List<string> returnList = new List<string>();
                        foreach (var parameter in operation.Parameters.OrderByDescending(x => x.IsRequired))
                        {
                            returnList.Add($"{PascalCase(parameter.Name)}");
                        }
                        context.Write($"var returnobject = _client.{module}Module.{PascalCase(operationId)}({string.Join(", ", returnList)});");
                    }
                }
                else if (response.Value.Schema?.Type != JsonObjectType.None)
                {
                    string className = response.Value.Schema.Type.ToString().ToLower();
                    if (arguments[1] as string == "full")
                    {
                        context.Write($"{className}");
                    }
                    else if (arguments[1] as string == "bare")
                    {
                        context.Write($"{className}");
                    }
                    else if (arguments[1] as string == "init")
                    {
                        context.Write($"{className}? returnValue  = default({className});");
                    }
                    else if (arguments[1] as string == "cast")
                    {
                        context.Write($"returnValue = JsonConvert.DeserializeObject<{className}>(response.Content, defaultSerializationSettings);");
                    }
                    else if (arguments[1] as string == "return")
                    {
                        var okResponse = operation.Responses.FirstOrDefault(x => x.Key.StartsWith("20"));
                        if (okResponse.Value.Schema != null)
                        {
                            context.Write("return response.Data;");
                        }
                    }
                    else if (arguments[1] as string == "cmdlet")
                    {
                        context.Write($"[OutputType(typeof({className}))]");
                    }
                    else if (arguments[1] as string == "cmdletreturn")
                    {
                        string module = arguments[2] as string;
                        string operationId = operation.OperationId;
                        List<string> returnList = new List<string>();
                        foreach (var parameter in operation.Parameters.OrderByDescending(x => x.IsRequired))
                        {
                            returnList.Add($"{PascalCase(parameter.Name)}");
                        }
                        context.Write($"var returnobject = _client.{module}Module.{PascalCase(operationId)}({string.Join(", ", returnList)});");
                    }
                }
            }
            else
            {
                if (arguments[1] as string == "full")
                {
                    context.Write("void");
                }
                else if (arguments[1] as string == "bare")
                {
                }
                else if (arguments[1] as string == "init")
                {
                }
                else if (arguments[1] as string == "cast")
                {
                }
                else if (arguments[1] as string == "return")
                {
                }
                else if (arguments[1] as string == "cmdlet")
                {
                }
                else if (arguments[1] as string == "cmdletreturn")
                {
                    string module = arguments[2] as string;
                    string operationId = operation.OperationId;
                    List<string> returnList = new();
                    foreach (var parameter in operation.Parameters.OrderByDescending(x => x.IsRequired))
                    {
                        returnList.Add($"{PascalCase(parameter.Name)}: {PascalCase(parameter.Name)}");
                    }
                    context.Write($"object returnobject = null; _client.{module}Module.{PascalCase(operationId)}({string.Join(", ", returnList)});");
                }
            }
        }
        private static void GetOperationHttpMethod(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            context.Write(CultureInfo.CurrentCulture.TextInfo.ToTitleCase((arguments[0] as OpenApiOperationDescription).Method));
        }
        private static void GetResponseType(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            ObservableDictionary<string, OpenApiResponse> responseList = arguments[0] as ObservableDictionary<string, OpenApiResponse>;
            var okResponse = responseList.FirstOrDefault(x => x.Key.StartsWith("20"));
            if (okResponse.Value.Schema != null)
            {
                if (okResponse.Value.Schema?.Reference != null)
                {
                    context.Write($"returnValue = JsonConvert.DeserializeObject<NSXTALB{((IJsonReferenceBase)okResponse.Value.Schema).ReferencePath.Split("/")[3]}Type>(response.Content, defaultSerializationSettings);");
                }
                else if (okResponse.Value.Schema?.Type != JsonObjectType.None)
                {
                    context.Write($"returnValue = JsonConvert.DeserializeObject<{okResponse.Value.Schema.Type.ToString().ToLower()}>(response.Content, defaultSerializationSettings);");
                }
            }
        }
        private static void GetOperationPathInjectionCode(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var parameter = (arguments[0] as OpenApiParameter);
            if (parameter.Kind == OpenApiParameterKind.Path)
            {
                var method = PascalCase($"{arguments[2]} {arguments[1].ToString().Replace("/", " ").Replace("{", " ").Replace("}", " ")}");
                context.Write($"{method}ServiceURL.Replace(\"{{{parameter.Name}}}\", Uri.EscapeDataString(Helpers.ConvertToString({PascalCase(parameter.Name)}, System.Globalization.CultureInfo.InvariantCulture)));");
            }
            else if (parameter.Kind == OpenApiParameterKind.Query)
            {
                context.Write($"if ({PascalCase(parameter.Name)} != null) {{ request.AddQueryParameter(\"{parameter.Name}\", JsonConvert.ToString({PascalCase(parameter.Name)}).ToLowerString()); }}");
            }
            else if (parameter.Kind == OpenApiParameterKind.Body)
            {
                if (parameter.Schema.AdditionalPropertiesSchema != null)
                {
                    context.Write($"request.AddParameter(\"text/plain\", {PascalCase(parameter.Name)}, ParameterType.RequestBody);");
                }
                else
                {
                    context.Write($"request.AddJsonBody({PascalCase(parameter.Name)});");
                }
            }
            else if (parameter.Kind == OpenApiParameterKind.Header)
            {
                context.Write($"if ({PascalCase(parameter.Name)} != null) request.AddHeader(\"{parameter.Name}\", {PascalCase(parameter.Name)});");
            }
            else
            {
                throw new NotSupportedException(parameter.Kind.ToString());
            }
        }
        private static void GetLowerCase(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var test = arguments[0];
            context.Write(arguments[0]?.ToString()?.ToLower());
        }
        private static void GetBool(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var test = arguments[0];
            context.Write(Boolean.Parse(arguments[0]?.ToString()).ToString());
        }
        private static void GetTuple(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            if (arguments != null && arguments.Count > 0 && arguments[0] is ITuple && options.TryGetValue("index", out var indexObj) && int.TryParse(indexObj?.ToString(), out var index))
            {
                var pair = (ITuple)arguments[0];
                var value = pair[index];
                context.Write(value.ToString());
            }
        }
        private static void GetMethodName(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var operation = ((OpenApiOperationDescription)arguments[0]);
            context.Write(PascalCase($"{operation.Method} {operation.Path.Replace("/", " ").Replace("{", " ").Replace("}", " ")}"));
        }
        private static void GetResponseName(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var (response, operation) = ((KeyValuePair<string, OpenApiResponse>)arguments[0]);
            context.Write(PascalCase(response));
        }
        private static void GetDotNetType(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is JsonSchemaProperty)
            {
                var parameter = arguments[0] as JsonSchemaProperty;
                if (parameter.Reference != null)
                {
                    context.Write(GetDotNetType(parameter, arguments));
                }
                else if (parameter != null)
                {
                    context.Write(GetDotNetType(parameter, arguments));
                }
            }
        }
        private static string GetDotNetType(OpenApiParameter parameter)
        {
            if (parameter.Schema != null)
            {
                var schema = (IJsonReferenceBase)parameter.Schema;
                if (schema.ReferencePath != null)
                {
                    return $"NSXTALB{schema?.ReferencePath.Split("/")[3]}Type{(parameter.IsRequired ? "" : "?")}";
                }
                else
                {
                    if (parameter.Schema.AdditionalPropertiesSchema.Type != null)
                    {
                        return $"{parameter.Schema.AdditionalPropertiesSchema.Type.ToString().ToLower()}{(parameter.IsRequired ? "" : "?")}";
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
            }
            switch (parameter.Type)
            {
                case JsonObjectType.Boolean:
                    return $"bool{(parameter.IsRequired ? "" : "?")}";
                case JsonObjectType.Integer:
                    switch (parameter.Format)
                    {
                        case "int64":
                            return $"long{(parameter.IsRequired ? "" : "?")}";
                        case "int32":
                        default:
                            return $"int{(parameter.IsRequired ? "" : "?")}";
                    }
                case JsonObjectType.Number:
                    return $"double{(parameter.IsRequired ? "" : "?")}";
                case JsonObjectType.String:
                    switch (parameter.Format)
                    {
                        case "byte":
                            return "byte[]";
                        case "date-time":
                            return $"System.DateTime{(parameter.IsRequired ? "" : "?")}";
                    }
                    return parameter.IsRequired ? "string" : "string?";
                case JsonObjectType.File:
                    return $"string{(parameter.IsRequired ? "" : "?")}";
                default:
                    //throw new NotSupportedException();
                    Console.WriteLine($"{parameter.Type} for {parameter.Name} not handeled");
                    return "object";
            }
        }
        private static string GetDotNetType(JsonSchemaProperty jsonType, IList<object> arguments)
        {
            if (jsonType.Name == "nodes")
            {
            }
            switch (jsonType.Type)
            {
                case JsonObjectType.Boolean:
                    if (jsonType.IsRequired)
                    {
                        return "bool";
                    }
                    else
                    {
                        return "bool?";
                    }
                case JsonObjectType.Integer:
                    switch (jsonType.Format)
                    {
                        case "int64":
                            if (jsonType.IsRequired)
                            {
                                return "long";
                            }
                            else
                            {
                                return "long?";
                            }
                        case "int32":
                        default:
                            if (jsonType.IsRequired)
                            {
                                return "int";
                            }
                            else
                            {
                                return "int?";
                            }
                    }
                case JsonObjectType.Number:
                    if (jsonType.IsRequired)
                    {
                        return "double";
                    }
                    else
                    {
                        return "double?";
                    }
                case JsonObjectType.String:
                    if (jsonType.Enumeration != null && jsonType.Enumeration.Count > 0)
                    {
                        return PascalCase($"NSXTALB {arguments[2]} {arguments[1]} enum type {(!jsonType.IsRequired ? "?" : "")}");
                    }
                    switch (jsonType.Format)
                    {
                        case "byte":
                            return "byte[]";
                        case "date-time":
                            if (jsonType.IsRequired)
                            {
                                return "System.DateTime";
                            }
                            else
                            {
                                return "System.DateTime?";
                            }
                    }
                    return jsonType.IsRequired ? "string" : "string?";
                case JsonObjectType.Array:
                    if (jsonType.Item?.Reference != null)
                    {
                        string _type = ((IJsonReferenceBase)jsonType.Item).ReferencePath.Split("/")[3];
                        //We need to manually set some of these types as the NSX-T Swagger definition is broken in some places.
                        if (_type.ToLower() == "IpInfo".ToLower())
                        {
                            _type = "IPInfo";
                        }
                        if (_type.ToLower() == "Snmpv3User".ToLower())
                        {
                            _type = "SnmpV3User";
                        }
                        return $"IList<NSXTALB{_type}Type>";
                    }
                    else
                    {
                        if (jsonType.Type == JsonObjectType.Array)
                        {
                            if (jsonType.Item.Type == JsonObjectType.Integer)
                            {
                                switch (jsonType.Item.Format)
                                {
                                    case "int64":
                                        if (jsonType.IsRequired)
                                        {
                                            return "long";
                                        }
                                        else
                                        {
                                            return "long?";
                                        }
                                    case "int32":
                                    default:
                                        if (jsonType.IsRequired)
                                        {
                                            return "int";
                                        }
                                        else
                                        {
                                            return "int?";
                                        }
                                }
                            }
                            else
                            {
                                if (jsonType.Item.Reference != null)
                                {
                                    return $"IList<NSXTALB{((IJsonReferenceBase)jsonType.Item).ReferencePath.Split("/")[3]}Type>";
                                }
                                else
                                {
                                    string _type = jsonType.Item.Type.ToString().ToLower();
                                    if (_type == "number")
                                    {
                                        _type = "float";
                                    }
                                    return $"IList<{_type}>";
                                }
                            }
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                case JsonObjectType.Object:
                    if (jsonType.IsRequired)
                    {
                        return "object";
                    }
                    else
                    {
                        return "object?";
                    }
                case JsonObjectType.None:
                    if (jsonType.Reference != null)
                    {
                        string _type = ((IJsonReferenceBase)jsonType).ReferencePath.Split("/")[3];
                        //We need to manually set some of these types as the NSX-T Swagger definition is broken in some places.
                        if (_type.ToLower() == "IpInfo".ToLower())
                        {
                            _type = "IPInfo";
                        }
                        if (_type.ToLower() == "Snmpv3User".ToLower())
                        {
                            _type = "SnmpV3User";
                        }
                        return $"NSXTALB{_type}Type";
                    }
                    else
                    {
                        return "object";
                    }
                default:
                    throw new NotSupportedException();
            }
        }
        private static void GetDotNetName(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is JsonSchemaProperty)
            {
                var parameter = arguments[0] as JsonSchemaProperty;
                context.Write(PascalCase(parameter.Name));
            }
            else if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is OpenApiParameter)
            {
                var parameter = arguments[0] as OpenApiParameter;
                context.Write(GetDotNetName(parameter.Name));
                if (arguments.Count > 1 && arguments[1] as string == "true" && !parameter.IsRequired)
                {
                    context.Write($" = null");
                }
            }
            else if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is string)
            {
                var style = "parameter";
                if (arguments.Count > 1)
                {
                    style = arguments[1] as string;
                }
                context.Write(GetDotNetName((string)arguments[0], style));
            }
            else
            {
                context.Write("fieldname");
            }
        }
        private static string GetDotNetName(string jsonName, string style = "parameter")
        {
            switch (style)
            {
                case "parameter":
                    if (jsonName == "namespace")
                    {
                        return "namespaceParameter";
                    }
                    else if (jsonName == "continue")
                    {
                        return "continueParameter";
                    }
                    break;
                case "fieldctor":
                    if (jsonName == "namespace")
                    {
                        return "namespaceProperty";
                    }
                    else if (jsonName == "continue")
                    {
                        return "continueProperty";
                    }
                    else if (jsonName == "__referencePath")
                    {
                        return "refProperty";
                    }
                    else if (jsonName == "default")
                    {
                        return "defaultProperty";
                    }
                    else if (jsonName == "operator")
                    {
                        return "operatorProperty";
                    }
                    else if (jsonName == "$schema")
                    {
                        return "schema";
                    }
                    else if (jsonName == "enum")
                    {
                        return "enumProperty";
                    }
                    else if (jsonName == "object")
                    {
                        return "objectProperty";
                    }
                    else if (jsonName == "readOnly")
                    {
                        return "readOnlyProperty";
                    }
                    else if (jsonName == "from")
                    {
                        return "fromProperty";
                    }
                    return jsonName.ToCamelCase();
                case "field":
                    return GetDotNetName(jsonName, "fieldctor").ToPascalCase();
            }
            return jsonName.ToCamelCase();
        }
        private static string ToPascalCase(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return name;
            }
            return char.ToUpper(name[0]) + name.Substring(1);
        }
        public static string PascalCase(string str)
        {
            if (str != null)
            {
                TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
                str = Regex.Replace(str, "([A-Z]+)", " $1");
                str = cultInfo.ToTitleCase(str);
                str = str.Replace(" ", "");
                str = str.Replace("_", "");
                str = str.Replace("-", "");
                str = str.Replace("+", "_");
                str = str.Replace(".", "");
            }
            return str;
        }
        public static IEnumerable<string> WordWrap(string text, int width)
        {
            var lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                var processedLine = line.Trim();
                // yield empty lines as they are (probably) intensional
                if (processedLine.Length == 0)
                {
                    yield return processedLine;
                }
                // feast on the line until it's gone
                while (processedLine.Length > 0)
                {
                    // determine potential wrapping points
                    var whitespacePositions = Enumerable
                        .Range(0, processedLine.Length)
                        .Where(i => char.IsWhiteSpace(processedLine[i]))
                        .Concat(new[] { processedLine.Length })
                        .Cast<int?>();
                    var preWidthWrapAt = whitespacePositions.LastOrDefault(i => i <= width);
                    var postWidthWrapAt = whitespacePositions.FirstOrDefault(i => i > width);
                    // choose preferred wrapping point
                    var wrapAt = preWidthWrapAt ?? postWidthWrapAt ?? processedLine.Length;
                    // wrap
                    yield return processedLine.Substring(0, wrapAt);
                    processedLine = processedLine.Substring(wrapAt).Trim();
                }
            }
        }
        static List<string> StringSplitter(string stringToSplit)
        {
            List<string> result = new List<string>();
            bool wasPreviousUppercase = false;
            StringBuilder current = new StringBuilder();
            foreach (char c in stringToSplit)
            {
                if (char.IsUpper(c))
                {
                    if (wasPreviousUppercase)
                    {
                        current.Append(c);
                    }
                    else
                    {
                        if (current.Length > 0)
                        {
                            result.Add(current.ToString());
                            current.Length = 0;
                        }
                        current.Append(c);
                    }
                    wasPreviousUppercase = true;
                }
                else  // lowercase
                {
                    if (wasPreviousUppercase)
                    {
                        if (current.Length > 1)
                        {
                            char carried = current[current.Length - 1];
                            --current.Length;
                            result.Add(current.ToString());
                            current.Length = 0;
                            current.Append(carried);
                        }
                    }
                    wasPreviousUppercase = false;
                    if (current.Length == 0)
                    {
                        current.Append(char.ToUpper(c));
                    }
                    else
                    {
                        current.Append(c);
                    }
                }
            }
            if (current.Length > 0)
            {
                result.Add(current.ToString());
            }
            return result;
        }
        public class EnumType
        {
            public EnumType()
            {
                Values = new List<EnumValueType>();
            }
            public string EnumName { get; set; }
            public string Description { get; set; }
            public List<EnumValueType> Values { get; set; }
        }
        public class EnumValueType
        {
            public string EnumValue { get; set; }
            public string JsonEnumValue { get; set; }
            public int EnumIndex { get; set; }
        }
    }
    class apiSpecification
    {
        public string Name { get; set; }
        public OpenApiDocument ApiDocument { get; set; }
    }
}
