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
    public class PoolGroupDeploymentPolicy
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        CancellationToken cancellationToken;
        int timeout;
        int retry;
        string defaultXAviVerion;
         List<RestResponseCookie> sessionCookies;
        public PoolGroupDeploymentPolicy(RestClient Client, List<RestResponseCookie> _sessionCookies, JsonSerializerSettings _defaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry, string _defaultXAviVerion)
        {
            restClient = Client;
            defaultSerializationSettings = _defaultSerializationSettings;
            cancellationToken = _cancellationToken;
            retry = _retry;
            timeout = _timeout;
            defaultXAviVerion = _defaultXAviVerion;
            sessionCookies = _sessionCookies;
        }
        public async Task<NSXTALBPoolGroupDeploymentPolicyApiResponseType> GetPoolgroupdeploymentpolicy(string? Name = null, string? RefersTo = null, string? ReferredBy = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            
            
            
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            StringBuilder GetPoolgroupdeploymentpolicyServiceURL = new StringBuilder("/api/poolgroupdeploymentpolicy");
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
            request.Resource = GetPoolgroupdeploymentpolicyServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken"), ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid"), ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBPoolGroupDeploymentPolicyApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolGroupDeploymentPolicyApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetPoolgroupdeploymentpolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers);
			}
            return response.Data;
        }
        public async Task<NSXTALBPoolGroupDeploymentPolicyType> PostPoolgroupdeploymentpolicy(NSXTALBPoolGroupDeploymentPolicyType Body, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            StringBuilder PostPoolgroupdeploymentpolicyServiceURL = new StringBuilder("/api/poolgroupdeploymentpolicy");
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
            request.Resource = PostPoolgroupdeploymentpolicyServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken"), ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid"), ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBPoolGroupDeploymentPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolGroupDeploymentPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + PostPoolgroupdeploymentpolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers);
			}
            return response.Data;
        }
        public async Task<NSXTALBPoolGroupDeploymentPolicyType> GetPoolgroupdeploymentpolicyUuid(string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            
            
            
            
            StringBuilder GetPoolgroupdeploymentpolicyUuidServiceURL = new StringBuilder("/api/poolgroupdeploymentpolicy/{uuid}");
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
            GetPoolgroupdeploymentpolicyUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (Fields != null) { request.AddQueryParameter("fields", JsonConvert.ToString(Fields).ToLowerString()); }
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", JsonConvert.ToString(SkipDefault).ToLowerString()); }
            if (JoinSubresources != null) { request.AddQueryParameter("join_subresources", JsonConvert.ToString(JoinSubresources).ToLowerString()); }
            request.Resource = GetPoolgroupdeploymentpolicyUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken"), ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid"), ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBPoolGroupDeploymentPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolGroupDeploymentPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetPoolgroupdeploymentpolicyUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers);
			}
            return response.Data;
        }
        public async Task<NSXTALBPoolGroupDeploymentPolicyType> PutPoolgroupdeploymentpolicyUuid(NSXTALBPoolGroupDeploymentPolicyType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PutPoolgroupdeploymentpolicyUuidServiceURL = new StringBuilder("/api/poolgroupdeploymentpolicy/{uuid}");
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
            request.AddJsonBody(JsonConvert.SerializeObject(Body, defaultSerializationSettings));
            PutPoolgroupdeploymentpolicyUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PutPoolgroupdeploymentpolicyUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken"), ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid"), ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBPoolGroupDeploymentPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolGroupDeploymentPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + PutPoolgroupdeploymentpolicyUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers);
			}
            return response.Data;
        }
        public async Task<NSXTALBPoolGroupDeploymentPolicyType> PatchPoolgroupdeploymentpolicyUuid(NSXTALBPoolGroupDeploymentPolicyType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PatchPoolgroupdeploymentpolicyUuidServiceURL = new StringBuilder("/api/poolgroupdeploymentpolicy/{uuid}");
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
            request.AddJsonBody(JsonConvert.SerializeObject(Body, defaultSerializationSettings));
            PatchPoolgroupdeploymentpolicyUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PatchPoolgroupdeploymentpolicyUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken"), ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid"), ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBPoolGroupDeploymentPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolGroupDeploymentPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchPoolgroupdeploymentpolicyUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers);
			}
            return response.Data;
        }
        public async Task<string> DeletePoolgroupdeploymentpolicyUuid(string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder DeletePoolgroupdeploymentpolicyUuidServiceURL = new StringBuilder("/api/poolgroupdeploymentpolicy/{uuid}");
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
            DeletePoolgroupdeploymentpolicyUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePoolgroupdeploymentpolicyUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken"), ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid"), ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeletePoolgroupdeploymentpolicyUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers);
			}
            return response.Data;
        }
    }
}
