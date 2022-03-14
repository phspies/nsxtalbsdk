
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using nsxtalbsdk;
using nsxtalbsdk.Models;

namespace nsxtalbsdk.Modules
{
    public class WafPolicy
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public WafPolicy(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        public NSXTALBWafPolicyApiResponseType GetWafpolicy(string XAviVersion, string? Name = null, string? RefersTo = null, string? ReferredBy = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            NSXTALBWafPolicyApiResponseType? returnValue = default(NSXTALBWafPolicyApiResponseType);
            StringBuilder GetWafpolicyServiceURL = new StringBuilder("/api/wafpolicy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Name != null) { request.AddQueryParameter("name", Name.ToString()); }
            if (RefersTo != null) { request.AddQueryParameter("refers_to", RefersTo.ToString()); }
            if (ReferredBy != null) { request.AddQueryParameter("referred_by", ReferredBy.ToString()); }
            if (Fields != null) { request.AddQueryParameter("fields", Fields.ToString()); }
            if (IncludeName != null) { request.AddQueryParameter("include_name", IncludeName.ToString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", SkipDefault.ToString()); }
            if (JoinSubresources != null) { request.AddQueryParameter("join_subresources", JoinSubresources.ToString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XAviVersion != null) request.AddHeader("X-Avi-Version", XAviVersion);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            request.Resource = GetWafpolicyServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetWafpolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBWafPolicyApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBWafPolicyApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBWafPolicyType PostWafpolicy(string XAviVersion, NSXTALBWafPolicyType Body, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            NSXTALBWafPolicyType? returnValue = default(NSXTALBWafPolicyType);
            StringBuilder PostWafpolicyServiceURL = new StringBuilder("/api/wafpolicy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XAviVersion != null) request.AddHeader("X-Avi-Version", XAviVersion);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            request.AddJsonBody(JsonConvert.SerializeObject(Body, defaultSerializationSettings));
            request.Resource = PostWafpolicyServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + PostWafpolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBWafPolicyType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBWafPolicyType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBWafPolicyType GetWafpolicyUuid(string XAviVersion, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBWafPolicyType? returnValue = default(NSXTALBWafPolicyType);
            StringBuilder GetWafpolicyUuidServiceURL = new StringBuilder("/api/wafpolicy/{uuid}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Name != null) { request.AddQueryParameter("name", Name.ToString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XAviVersion != null) request.AddHeader("X-Avi-Version", XAviVersion);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            GetWafpolicyUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (Fields != null) { request.AddQueryParameter("fields", Fields.ToString()); }
            if (IncludeName != null) { request.AddQueryParameter("include_name", IncludeName.ToString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", SkipDefault.ToString()); }
            if (JoinSubresources != null) { request.AddQueryParameter("join_subresources", JoinSubresources.ToString()); }
            request.Resource = GetWafpolicyUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetWafpolicyUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBWafPolicyType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBWafPolicyType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBWafPolicyType PutWafpolicyUuid(string XAviVersion, NSXTALBWafPolicyType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBWafPolicyType? returnValue = default(NSXTALBWafPolicyType);
            StringBuilder PutWafpolicyUuidServiceURL = new StringBuilder("/api/wafpolicy/{uuid}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            if (Name != null) { request.AddQueryParameter("name", Name.ToString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XAviVersion != null) request.AddHeader("X-Avi-Version", XAviVersion);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            request.AddJsonBody(JsonConvert.SerializeObject(Body, defaultSerializationSettings));
            PutWafpolicyUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PutWafpolicyUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + PutWafpolicyUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBWafPolicyType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBWafPolicyType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBWafPolicyType PatchWafpolicyUuid(string XAviVersion, NSXTALBWafPolicyType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBWafPolicyType? returnValue = default(NSXTALBWafPolicyType);
            StringBuilder PatchWafpolicyUuidServiceURL = new StringBuilder("/api/wafpolicy/{uuid}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            if (Name != null) { request.AddQueryParameter("name", Name.ToString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XAviVersion != null) request.AddHeader("X-Avi-Version", XAviVersion);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            request.AddJsonBody(JsonConvert.SerializeObject(Body, defaultSerializationSettings));
            PatchWafpolicyUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PatchWafpolicyUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchWafpolicyUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBWafPolicyType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBWafPolicyType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public string DeleteWafpolicyUuid(string XAviVersion, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            string? returnValue  = default(string);
            StringBuilder DeleteWafpolicyUuidServiceURL = new StringBuilder("/api/wafpolicy/{uuid}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            if (Name != null) { request.AddQueryParameter("name", Name.ToString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XAviVersion != null) request.AddHeader("X-Avi-Version", XAviVersion);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            DeleteWafpolicyUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteWafpolicyUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteWafpolicyUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = (string)response.Content;
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(string).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
