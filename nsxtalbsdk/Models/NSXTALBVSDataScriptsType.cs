using nsxtalbsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVSDataScriptsType 
    {
        /// <summary>
        /// Index of the virtual service datascript collection.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// UUID of the virtual service datascript collection. It is a reference to an object of type VSDataScriptSet.
        /// </summary>
        [JsonProperty(PropertyName = "vs_datascript_set_ref", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VsDatascriptSetRef { get; set; }
    }
}
