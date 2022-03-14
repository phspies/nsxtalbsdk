
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
    public class Pkiprofile
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public Pkiprofile(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        public NSXTALBPKIProfileApiResponseType GetPkiprofile(string XAviVersion, string? Name = null, string? RefersTo = null, string? ReferredBy = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            NSXTALBPKIProfileApiResponseType? returnValue = default(NSXTALBPKIProfileApiResponseType);
            StringBuilder GetPkiprofileServiceURL = new StringBuilder("/api/pkiprofile");
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
            request.Resource = GetPkiprofileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetPkiprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBPKIProfileApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBPKIProfileApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBPKIProfileType PostPkiprofile(string XAviVersion, NSXTALBPKIProfileType Body, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            NSXTALBPKIProfileType? returnValue = default(NSXTALBPKIProfileType);
            StringBuilder PostPkiprofileServiceURL = new StringBuilder("/api/pkiprofile");
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
            request.Resource = PostPkiprofileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + PostPkiprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBPKIProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBPKIProfileType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBPKIProfileType GetPkiprofileUuid(string XAviVersion, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBPKIProfileType? returnValue = default(NSXTALBPKIProfileType);
            StringBuilder GetPkiprofileUuidServiceURL = new StringBuilder("/api/pkiprofile/{uuid}");
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
            GetPkiprofileUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (Fields != null) { request.AddQueryParameter("fields", Fields.ToString()); }
            if (IncludeName != null) { request.AddQueryParameter("include_name", IncludeName.ToString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", SkipDefault.ToString()); }
            if (JoinSubresources != null) { request.AddQueryParameter("join_subresources", JoinSubresources.ToString()); }
            request.Resource = GetPkiprofileUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetPkiprofileUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBPKIProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBPKIProfileType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBPKIProfileType PutPkiprofileUuid(string XAviVersion, NSXTALBPKIProfileType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBPKIProfileType? returnValue = default(NSXTALBPKIProfileType);
            StringBuilder PutPkiprofileUuidServiceURL = new StringBuilder("/api/pkiprofile/{uuid}");
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
            PutPkiprofileUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PutPkiprofileUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + PutPkiprofileUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBPKIProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBPKIProfileType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBPKIProfileType PatchPkiprofileUuid(string XAviVersion, NSXTALBPKIProfileType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBPKIProfileType? returnValue = default(NSXTALBPKIProfileType);
            StringBuilder PatchPkiprofileUuidServiceURL = new StringBuilder("/api/pkiprofile/{uuid}");
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
            PatchPkiprofileUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PatchPkiprofileUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchPkiprofileUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBPKIProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBPKIProfileType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public string DeletePkiprofileUuid(string XAviVersion, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            string? returnValue  = default(string);
            StringBuilder DeletePkiprofileUuidServiceURL = new StringBuilder("/api/pkiprofile/{uuid}");
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
            DeletePkiprofileUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePkiprofileUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeletePkiprofileUuidServiceURL.ToString() + " did not complete successfull";
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
        public string GetPkiprofileUuidFederatedInfo(string XAviVersion, string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (XAviVersion == null) { throw new ArgumentNullException("XAviVersion cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            string? returnValue  = default(string);
            StringBuilder GetPkiprofileUuidFederatedInfoServiceURL = new StringBuilder("/api/pkiprofile/{uuid}/federated_info/");
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
            GetPkiprofileUuidFederatedInfoServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPkiprofileUuidFederatedInfoServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetPkiprofileUuidFederatedInfoServiceURL.ToString() + " did not complete successfull";
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
