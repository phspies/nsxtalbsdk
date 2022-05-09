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
    public class FederationCheckpoint
    {
        private RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        private string defaultXAviVerion;
        private List<RestResponseCookie> sessionCookies;
        public FederationCheckpoint(RestClient Client, List<RestResponseCookie> _sessionCookies, CancellationToken _cancellationToken, int _timeout, int _retry, string _defaultXAviVerion)
        {
            restClient = Client;
            cancellationToken = _cancellationToken;
            retry = _retry;
            timeout = _timeout;
            defaultXAviVerion = _defaultXAviVerion;
            sessionCookies = _sessionCookies;
        }
        public async Task<NSXTALBFederationCheckpointApiResponseType> GetFederationcheckpointAsync(string? Name = null, string? RefersTo = null, string? ReferredBy = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            
            
            
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            StringBuilder GetFederationcheckpointServiceURL = new StringBuilder("/api/federationcheckpoint");
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
            request.Resource = GetFederationcheckpointServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBFederationCheckpointApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBFederationCheckpointApiResponseType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetFederationcheckpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBFederationCheckpointType> PostFederationcheckpointAsync(NSXTALBFederationCheckpointType Body, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            StringBuilder PostFederationcheckpointServiceURL = new StringBuilder("/api/federationcheckpoint");
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
            request.Resource = PostFederationcheckpointServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBFederationCheckpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBFederationCheckpointType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP POST operation to " + PostFederationcheckpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBFederationCheckpointType> GetFederationcheckpointUuidAsync(string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            
            
            
            
            StringBuilder GetFederationcheckpointUuidServiceURL = new StringBuilder("/api/federationcheckpoint/{uuid}");
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
            GetFederationcheckpointUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (Fields != null) { request.AddQueryParameter("fields", JsonConvert.ToString(Fields).ToLowerString()); }
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", JsonConvert.ToString(SkipDefault).ToLowerString()); }
            if (JoinSubresources != null) { request.AddQueryParameter("join_subresources", JsonConvert.ToString(JoinSubresources).ToLowerString()); }
            request.Resource = GetFederationcheckpointUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBFederationCheckpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBFederationCheckpointType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetFederationcheckpointUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBFederationCheckpointType> PutFederationcheckpointUuidAsync(NSXTALBFederationCheckpointType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PutFederationcheckpointUuidServiceURL = new StringBuilder("/api/federationcheckpoint/{uuid}");
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
            PutFederationcheckpointUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PutFederationcheckpointUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBFederationCheckpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBFederationCheckpointType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP PUT operation to " + PutFederationcheckpointUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBFederationCheckpointType> PatchFederationcheckpointUuidAsync(NSXTALBFederationCheckpointType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PatchFederationcheckpointUuidServiceURL = new StringBuilder("/api/federationcheckpoint/{uuid}");
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
            PatchFederationcheckpointUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PatchFederationcheckpointUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBFederationCheckpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBFederationCheckpointType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP PATCH operation to " + PatchFederationcheckpointUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> DeleteFederationcheckpointUuidAsync(string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder DeleteFederationcheckpointUuidServiceURL = new StringBuilder("/api/federationcheckpoint/{uuid}");
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
            DeleteFederationcheckpointUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteFederationcheckpointUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP DELETE operation to " + DeleteFederationcheckpointUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetFederationcheckpointUuidPendingobjectsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetFederationcheckpointUuidPendingobjectsServiceURL = new StringBuilder("/api/federationcheckpoint/{uuid}/pendingobjects/");
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
            GetFederationcheckpointUuidPendingobjectsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFederationcheckpointUuidPendingobjectsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetFederationcheckpointUuidPendingobjectsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
