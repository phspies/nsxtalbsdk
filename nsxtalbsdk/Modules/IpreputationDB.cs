
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
    public class IpreputationDB
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public IpreputationDB(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        public NSXTALBIPReputationDBApiResponseType GetIpreputationdb(string XAviVersion, string? Name = null, string? RefersTo = null, string? ReferredBy = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            NSXTALBIPReputationDBApiResponseType? returnValue = default(NSXTALBIPReputationDBApiResponseType);
            StringBuilder GetIpreputationdbServiceURL = new StringBuilder("/api/ipreputationdb");
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
            request.Resource = GetIpreputationdbServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetIpreputationdbServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBIPReputationDBApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBIPReputationDBApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBIPReputationDBType PostIpreputationdb(string XAviVersion, NSXTALBIPReputationDBType Body, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            NSXTALBIPReputationDBType? returnValue = default(NSXTALBIPReputationDBType);
            StringBuilder PostIpreputationdbServiceURL = new StringBuilder("/api/ipreputationdb");
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
            request.Resource = PostIpreputationdbServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + PostIpreputationdbServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBIPReputationDBType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBIPReputationDBType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBIPReputationDBType GetIpreputationdbUuid(string XAviVersion, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBIPReputationDBType? returnValue = default(NSXTALBIPReputationDBType);
            StringBuilder GetIpreputationdbUuidServiceURL = new StringBuilder("/api/ipreputationdb/{uuid}");
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
            GetIpreputationdbUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (Fields != null) { request.AddQueryParameter("fields", Fields.ToString()); }
            if (IncludeName != null) { request.AddQueryParameter("include_name", IncludeName.ToString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", SkipDefault.ToString()); }
            if (JoinSubresources != null) { request.AddQueryParameter("join_subresources", JoinSubresources.ToString()); }
            request.Resource = GetIpreputationdbUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetIpreputationdbUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBIPReputationDBType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBIPReputationDBType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBIPReputationDBType PutIpreputationdbUuid(string XAviVersion, NSXTALBIPReputationDBType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBIPReputationDBType? returnValue = default(NSXTALBIPReputationDBType);
            StringBuilder PutIpreputationdbUuidServiceURL = new StringBuilder("/api/ipreputationdb/{uuid}");
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
            PutIpreputationdbUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PutIpreputationdbUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + PutIpreputationdbUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBIPReputationDBType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBIPReputationDBType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBIPReputationDBType PatchIpreputationdbUuid(string XAviVersion, NSXTALBIPReputationDBType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBIPReputationDBType? returnValue = default(NSXTALBIPReputationDBType);
            StringBuilder PatchIpreputationdbUuidServiceURL = new StringBuilder("/api/ipreputationdb/{uuid}");
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
            PatchIpreputationdbUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PatchIpreputationdbUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchIpreputationdbUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBIPReputationDBType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBIPReputationDBType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public string DeleteIpreputationdbUuid(string XAviVersion, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            string? returnValue  = default(string);
            StringBuilder DeleteIpreputationdbUuidServiceURL = new StringBuilder("/api/ipreputationdb/{uuid}");
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
            DeleteIpreputationdbUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpreputationdbUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteIpreputationdbUuidServiceURL.ToString() + " did not complete successfull";
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
        public string GetIpreputationdbUuidRuntimeInternal(string XAviVersion, string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            string? returnValue  = default(string);
            StringBuilder GetIpreputationdbUuidRuntimeInternalServiceURL = new StringBuilder("/api/ipreputationdb/{uuid}/runtime/internal/");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            if (XAviVersion != null) request.AddHeader("X-Avi-Version", XAviVersion);
            GetIpreputationdbUuidRuntimeInternalServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpreputationdbUuidRuntimeInternalServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetIpreputationdbUuidRuntimeInternalServiceURL.ToString() + " did not complete successfull";
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
