
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
    public class AlbservicesFileUpload
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public AlbservicesFileUpload(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        public NSXTALBALBServicesFileUploadApiResponseType GetAlbservicesfileupload(string XAviVersion, string? Name = null, string? RefersTo = null, string? ReferredBy = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            NSXTALBALBServicesFileUploadApiResponseType? returnValue = default(NSXTALBALBServicesFileUploadApiResponseType);
            StringBuilder GetAlbservicesfileuploadServiceURL = new StringBuilder("/api/albservicesfileupload");
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
            request.Resource = GetAlbservicesfileuploadServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAlbservicesfileuploadServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBALBServicesFileUploadApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBALBServicesFileUploadApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBALBServicesFileUploadType PostAlbservicesfileupload(string XAviVersion, NSXTALBALBServicesFileUploadType Body, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            NSXTALBALBServicesFileUploadType? returnValue = default(NSXTALBALBServicesFileUploadType);
            StringBuilder PostAlbservicesfileuploadServiceURL = new StringBuilder("/api/albservicesfileupload");
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
            request.Resource = PostAlbservicesfileuploadServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + PostAlbservicesfileuploadServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBALBServicesFileUploadType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBALBServicesFileUploadType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBALBServicesFileUploadType GetAlbservicesfileuploadUuid(string XAviVersion, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBALBServicesFileUploadType? returnValue = default(NSXTALBALBServicesFileUploadType);
            StringBuilder GetAlbservicesfileuploadUuidServiceURL = new StringBuilder("/api/albservicesfileupload/{uuid}");
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
            GetAlbservicesfileuploadUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (Fields != null) { request.AddQueryParameter("fields", Fields.ToString()); }
            if (IncludeName != null) { request.AddQueryParameter("include_name", IncludeName.ToString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", SkipDefault.ToString()); }
            if (JoinSubresources != null) { request.AddQueryParameter("join_subresources", JoinSubresources.ToString()); }
            request.Resource = GetAlbservicesfileuploadUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAlbservicesfileuploadUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBALBServicesFileUploadType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBALBServicesFileUploadType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBALBServicesFileUploadType PutAlbservicesfileuploadUuid(string XAviVersion, NSXTALBALBServicesFileUploadType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBALBServicesFileUploadType? returnValue = default(NSXTALBALBServicesFileUploadType);
            StringBuilder PutAlbservicesfileuploadUuidServiceURL = new StringBuilder("/api/albservicesfileupload/{uuid}");
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
            PutAlbservicesfileuploadUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PutAlbservicesfileuploadUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + PutAlbservicesfileuploadUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBALBServicesFileUploadType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBALBServicesFileUploadType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBALBServicesFileUploadType PatchAlbservicesfileuploadUuid(string XAviVersion, NSXTALBALBServicesFileUploadType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBALBServicesFileUploadType? returnValue = default(NSXTALBALBServicesFileUploadType);
            StringBuilder PatchAlbservicesfileuploadUuidServiceURL = new StringBuilder("/api/albservicesfileupload/{uuid}");
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
            PatchAlbservicesfileuploadUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PatchAlbservicesfileuploadUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchAlbservicesfileuploadUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBALBServicesFileUploadType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBALBServicesFileUploadType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public string DeleteAlbservicesfileuploadUuid(string XAviVersion, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            string? returnValue  = default(string);
            StringBuilder DeleteAlbservicesfileuploadUuidServiceURL = new StringBuilder("/api/albservicesfileupload/{uuid}");
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
            DeleteAlbservicesfileuploadUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteAlbservicesfileuploadUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteAlbservicesfileuploadUuidServiceURL.ToString() + " did not complete successfull";
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
