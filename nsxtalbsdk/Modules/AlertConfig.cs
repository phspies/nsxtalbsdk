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
using System.Linq;
using System.Collections.Generic;
namespace nsxtalbsdk.Modules
{
    public class AlertConfig
    {
        private RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        private string defaultXAviVerion;
        private List<RestResponseCookie> sessionCookies;
        public AlertConfig(RestClient Client, List<RestResponseCookie> _sessionCookies, CancellationToken _cancellationToken, int _timeout, int _retry, string _defaultXAviVerion)
        {
            restClient = Client;
            cancellationToken = _cancellationToken;
            retry = _retry;
            timeout = _timeout;
            defaultXAviVerion = _defaultXAviVerion;
            sessionCookies = _sessionCookies;
        }
        public async Task<NSXTALBAlertConfigApiResponseType> GetAlertconfigAsync(string? Name = null, string? RefersTo = null, string? ReferredBy = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            
            
            
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            StringBuilder GetAlertconfigServiceURL = new StringBuilder("/api/alertconfig");
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
            request.Resource = GetAlertconfigServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAlertConfigApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAlertConfigApiResponseType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetAlertconfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBAlertConfigType> PostAlertconfigAsync(NSXTALBAlertConfigType Body, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            StringBuilder PostAlertconfigServiceURL = new StringBuilder("/api/alertconfig");
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
            request.Resource = PostAlertconfigServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAlertConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAlertConfigType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP POST operation to " + PostAlertconfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBAlertConfigType> GetAlertconfigUuidAsync(string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            
            
            
            
            StringBuilder GetAlertconfigUuidServiceURL = new StringBuilder("/api/alertconfig/{uuid}");
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
            GetAlertconfigUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (Fields != null) { request.AddQueryParameter("fields", JsonConvert.ToString(Fields).ToLowerString()); }
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", JsonConvert.ToString(SkipDefault).ToLowerString()); }
            if (JoinSubresources != null) { request.AddQueryParameter("join_subresources", JsonConvert.ToString(JoinSubresources).ToLowerString()); }
            request.Resource = GetAlertconfigUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAlertConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAlertConfigType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetAlertconfigUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBAlertConfigType> PutAlertconfigUuidAsync(NSXTALBAlertConfigType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PutAlertconfigUuidServiceURL = new StringBuilder("/api/alertconfig/{uuid}");
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
            PutAlertconfigUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PutAlertconfigUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAlertConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAlertConfigType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP PUT operation to " + PutAlertconfigUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBAlertConfigType> PatchAlertconfigUuidAsync(NSXTALBAlertConfigType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PatchAlertconfigUuidServiceURL = new StringBuilder("/api/alertconfig/{uuid}");
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
            PatchAlertconfigUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PatchAlertconfigUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAlertConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAlertConfigType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP PATCH operation to " + PatchAlertconfigUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> DeleteAlertconfigUuidAsync(string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder DeleteAlertconfigUuidServiceURL = new StringBuilder("/api/alertconfig/{uuid}");
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
            DeleteAlertconfigUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteAlertconfigUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP DELETE operation to " + DeleteAlertconfigUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
