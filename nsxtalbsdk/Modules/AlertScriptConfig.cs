using Newtonsoft.Json;
using nsxtalbsdk.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace nsxtalbsdk.Modules
{
    public class AlertScriptConfig
    {
        private RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        private string defaultXAviVerion;
        private List<RestResponseCookie> sessionCookies;
        public AlertScriptConfig(RestClient Client, List<RestResponseCookie> _sessionCookies, CancellationToken _cancellationToken, int _timeout, int _retry, string _defaultXAviVerion)
        {
            restClient = Client;
            cancellationToken = _cancellationToken;
            retry = _retry;
            timeout = _timeout;
            defaultXAviVerion = _defaultXAviVerion;
            sessionCookies = _sessionCookies;
        }
        public async Task<NSXTALBAlertScriptConfigApiResponseType> GetAlertscriptconfigAsync(string? Name = null, string? RefersTo = null, string? ReferredBy = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            StringBuilder GetAlertscriptconfigServiceURL = new StringBuilder("/api/alertscriptconfig");
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Name != null) { request.AddQueryParameter("name", JsonConvert.ToString(Name).ToLowerString()); }
            if (RefersTo != null) { request.AddQueryParameter("refers_to", JsonConvert.ToString(RefersTo).ToLowerString()); }
            if (ReferredBy != null) { request.AddQueryParameter("referred_by", JsonConvert.ToString(ReferredBy).ToLowerString()); }
            if (Fields != null) { request.AddQueryParameter("fields", JsonConvert.ToString(Fields).ToLowerString()); }
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", JsonConvert.ToString(SkipDefault).ToLowerString()); }
            if (JoinSubresources != null) { request.AddQueryParameter("join_subresources", JsonConvert.ToString(JoinSubresources).ToLowerString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XAviVersion != null) request.AddHeader("X-Avi-Version", XAviVersion);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            request.Resource = GetAlertscriptconfigServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAlertScriptConfigApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAlertScriptConfigApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP GET operation to " + GetAlertscriptconfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<NSXTALBAlertScriptConfigType> PostAlertscriptconfigAsync(NSXTALBAlertScriptConfigType Body, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            StringBuilder PostAlertscriptconfigServiceURL = new StringBuilder("/api/alertscriptconfig");
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
            request.AddJsonBody(Body);
            request.Resource = PostAlertscriptconfigServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAlertScriptConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAlertScriptConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP POST operation to " + PostAlertscriptconfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<NSXTALBAlertScriptConfigType> GetAlertscriptconfigUuidAsync(string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetAlertscriptconfigUuidServiceURL = new StringBuilder("/api/alertscriptconfig/{uuid}");
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Name != null) { request.AddQueryParameter("name", JsonConvert.ToString(Name).ToLowerString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XAviVersion != null) request.AddHeader("X-Avi-Version", XAviVersion);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            GetAlertscriptconfigUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (Fields != null) { request.AddQueryParameter("fields", JsonConvert.ToString(Fields).ToLowerString()); }
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", JsonConvert.ToString(SkipDefault).ToLowerString()); }
            if (JoinSubresources != null) { request.AddQueryParameter("join_subresources", JsonConvert.ToString(JoinSubresources).ToLowerString()); }
            request.Resource = GetAlertscriptconfigUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAlertScriptConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAlertScriptConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP GET operation to " + GetAlertscriptconfigUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<NSXTALBAlertScriptConfigType> PutAlertscriptconfigUuidAsync(NSXTALBAlertScriptConfigType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PutAlertscriptconfigUuidServiceURL = new StringBuilder("/api/alertscriptconfig/{uuid}");
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            if (Name != null) { request.AddQueryParameter("name", JsonConvert.ToString(Name).ToLowerString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XAviVersion != null) request.AddHeader("X-Avi-Version", XAviVersion);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            request.AddJsonBody(Body);
            PutAlertscriptconfigUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PutAlertscriptconfigUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAlertScriptConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAlertScriptConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP PUT operation to " + PutAlertscriptconfigUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<NSXTALBAlertScriptConfigType> PatchAlertscriptconfigUuidAsync(NSXTALBAlertScriptConfigType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PatchAlertscriptconfigUuidServiceURL = new StringBuilder("/api/alertscriptconfig/{uuid}");
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            if (Name != null) { request.AddQueryParameter("name", JsonConvert.ToString(Name).ToLowerString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XAviVersion != null) request.AddHeader("X-Avi-Version", XAviVersion);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            request.AddJsonBody(Body);
            PatchAlertscriptconfigUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PatchAlertscriptconfigUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAlertScriptConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAlertScriptConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP PATCH operation to " + PatchAlertscriptconfigUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<string> DeleteAlertscriptconfigUuidAsync(string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder DeleteAlertscriptconfigUuidServiceURL = new StringBuilder("/api/alertscriptconfig/{uuid}");
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            if (Name != null) { request.AddQueryParameter("name", JsonConvert.ToString(Name).ToLowerString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XAviVersion != null) request.AddHeader("X-Avi-Version", XAviVersion);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            DeleteAlertscriptconfigUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteAlertscriptconfigUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP DELETE operation to " + DeleteAlertscriptconfigUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
    }
}
