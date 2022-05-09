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
    public class VirtualService
    {
        private RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        private string defaultXAviVerion;
        private List<RestResponseCookie> sessionCookies;
        public VirtualService(RestClient Client, List<RestResponseCookie> _sessionCookies, CancellationToken _cancellationToken, int _timeout, int _retry, string _defaultXAviVerion)
        {
            restClient = Client;
            cancellationToken = _cancellationToken;
            retry = _retry;
            timeout = _timeout;
            defaultXAviVerion = _defaultXAviVerion;
            sessionCookies = _sessionCookies;
        }
        public async Task<NSXTALBVirtualServiceApiResponseType> GetVirtualserviceAsync(string? Name = null, string? RefersTo = null, string? ReferredBy = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? CloudUuid = null, string? CloudRefName = null, string? XAviVersion = null)
        {
            
            
            
            
            
            
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            
            
            StringBuilder GetVirtualserviceServiceURL = new StringBuilder("/api/virtualservice");
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
            if (CloudUuid != null) { request.AddQueryParameter("cloud_uuid", JsonConvert.ToString(CloudUuid).ToLowerString()); }
            if (CloudRefName != null) { request.AddQueryParameter("cloud_ref.name", JsonConvert.ToString(CloudRefName).ToLowerString()); }
            request.Resource = GetVirtualserviceServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBVirtualServiceApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVirtualServiceApiResponseType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBVirtualServiceType> PostVirtualserviceAsync(NSXTALBVirtualServiceType Body, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            StringBuilder PostVirtualserviceServiceURL = new StringBuilder("/api/virtualservice");
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
            request.Resource = PostVirtualserviceServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBVirtualServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVirtualServiceType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP POST operation to " + PostVirtualserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBVirtualServiceType> GetVirtualserviceUuidAsync(string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            
            
            
            
            StringBuilder GetVirtualserviceUuidServiceURL = new StringBuilder("/api/virtualservice/{uuid}");
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
            GetVirtualserviceUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (Fields != null) { request.AddQueryParameter("fields", JsonConvert.ToString(Fields).ToLowerString()); }
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", JsonConvert.ToString(SkipDefault).ToLowerString()); }
            if (JoinSubresources != null) { request.AddQueryParameter("join_subresources", JsonConvert.ToString(JoinSubresources).ToLowerString()); }
            request.Resource = GetVirtualserviceUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBVirtualServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVirtualServiceType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBVirtualServiceType> PutVirtualserviceUuidAsync(NSXTALBVirtualServiceType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PutVirtualserviceUuidServiceURL = new StringBuilder("/api/virtualservice/{uuid}");
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
            PutVirtualserviceUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PutVirtualserviceUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBVirtualServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVirtualServiceType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP PUT operation to " + PutVirtualserviceUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBVirtualServiceType> PatchVirtualserviceUuidAsync(NSXTALBVirtualServiceType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PatchVirtualserviceUuidServiceURL = new StringBuilder("/api/virtualservice/{uuid}");
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
            PatchVirtualserviceUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PatchVirtualserviceUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBVirtualServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVirtualServiceType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP PATCH operation to " + PatchVirtualserviceUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> DeleteVirtualserviceUuidAsync(string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder DeleteVirtualserviceUuidServiceURL = new StringBuilder("/api/virtualservice/{uuid}");
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
            DeleteVirtualserviceUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteVirtualserviceUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP DELETE operation to " + DeleteVirtualserviceUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> PostVirtualserviceUuidScaleoutAsync(NSXTALBVsScaleoutParamsType Body, string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PostVirtualserviceUuidScaleoutServiceURL = new StringBuilder("/api/virtualservice/{uuid}/scaleout");
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
            PostVirtualserviceUuidScaleoutServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PostVirtualserviceUuidScaleoutServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP POST operation to " + PostVirtualserviceUuidScaleoutServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> PostVirtualserviceUuidScaleinAsync(NSXTALBVsScaleinParamsType Body, string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PostVirtualserviceUuidScaleinServiceURL = new StringBuilder("/api/virtualservice/{uuid}/scalein");
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
            PostVirtualserviceUuidScaleinServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PostVirtualserviceUuidScaleinServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP POST operation to " + PostVirtualserviceUuidScaleinServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> PostVirtualserviceUuidMigrateAsync(NSXTALBVsMigrateParamsType Body, string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PostVirtualserviceUuidMigrateServiceURL = new StringBuilder("/api/virtualservice/{uuid}/migrate");
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
            PostVirtualserviceUuidMigrateServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PostVirtualserviceUuidMigrateServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP POST operation to " + PostVirtualserviceUuidMigrateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> PostVirtualserviceUuidSwitchoverAsync(NSXTALBVsSwitchoverParamsType Body, string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PostVirtualserviceUuidSwitchoverServiceURL = new StringBuilder("/api/virtualservice/{uuid}/switchover");
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
            PostVirtualserviceUuidSwitchoverServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PostVirtualserviceUuidSwitchoverServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP POST operation to " + PostVirtualserviceUuidSwitchoverServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> PostVirtualserviceClearAsync(string Body, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            StringBuilder PostVirtualserviceClearServiceURL = new StringBuilder("/api/virtualservice/clear");
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
            request.AddParameter("text/plain", Body, ParameterType.RequestBody);
            request.Resource = PostVirtualserviceClearServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP POST operation to " + PostVirtualserviceClearServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> PostVirtualserviceUuidResyncAsync(NSXTALBVsResyncParamsType Body, string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PostVirtualserviceUuidResyncServiceURL = new StringBuilder("/api/virtualservice/{uuid}/resync");
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
            PostVirtualserviceUuidResyncServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PostVirtualserviceUuidResyncServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP POST operation to " + PostVirtualserviceUuidResyncServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> PostVirtualserviceUuidRotatekeysAsync(string Body, string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PostVirtualserviceUuidRotatekeysServiceURL = new StringBuilder("/api/virtualservice/{uuid}/rotatekeys");
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
            request.AddParameter("text/plain", Body, ParameterType.RequestBody);
            PostVirtualserviceUuidRotatekeysServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PostVirtualserviceUuidRotatekeysServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP POST operation to " + PostVirtualserviceUuidRotatekeysServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> PostVirtualserviceUuidApicplacementAsync(NSXTALBApicVSPlacementReqType Body, string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PostVirtualserviceUuidApicplacementServiceURL = new StringBuilder("/api/virtualservice/{uuid}/apicplacement");
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
            PostVirtualserviceUuidApicplacementServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PostVirtualserviceUuidApicplacementServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP POST operation to " + PostVirtualserviceUuidApicplacementServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> PostVirtualserviceUuidRetryplacementAsync(NSXTALBRetryPlacementParamsType Body, string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PostVirtualserviceUuidRetryplacementServiceURL = new StringBuilder("/api/virtualservice/{uuid}/retryplacement");
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
            PostVirtualserviceUuidRetryplacementServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PostVirtualserviceUuidRetryplacementServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP POST operation to " + PostVirtualserviceUuidRetryplacementServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidRuntimeAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidRuntimeServiceURL = new StringBuilder("/api/virtualservice/{uuid}/runtime/");
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
            GetVirtualserviceUuidRuntimeServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidRuntimeServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidRuntimeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidRuntimeDetailAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidRuntimeDetailServiceURL = new StringBuilder("/api/virtualservice/{uuid}/runtime/detail/");
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
            GetVirtualserviceUuidRuntimeDetailServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidRuntimeDetailServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidRuntimeDetailServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidRuntimeInternalAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidRuntimeInternalServiceURL = new StringBuilder("/api/virtualservice/{uuid}/runtime/internal/");
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
            GetVirtualserviceUuidRuntimeInternalServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidRuntimeInternalServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidRuntimeInternalServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidUdpstatAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidUdpstatServiceURL = new StringBuilder("/api/virtualservice/{uuid}/udpstat/");
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
            GetVirtualserviceUuidUdpstatServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidUdpstatServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidUdpstatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidTcpstatAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidTcpstatServiceURL = new StringBuilder("/api/virtualservice/{uuid}/tcpstat/");
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
            GetVirtualserviceUuidTcpstatServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidTcpstatServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidTcpstatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidTrafficCloneStatsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidTrafficCloneStatsServiceURL = new StringBuilder("/api/virtualservice/{uuid}/traffic_clone_stats/");
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
            GetVirtualserviceUuidTrafficCloneStatsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidTrafficCloneStatsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidTrafficCloneStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidDosstatAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidDosstatServiceURL = new StringBuilder("/api/virtualservice/{uuid}/dosstat/");
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
            GetVirtualserviceUuidDosstatServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidDosstatServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidDosstatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidConnectionsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidConnectionsServiceURL = new StringBuilder("/api/virtualservice/{uuid}/connections/");
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
            GetVirtualserviceUuidConnectionsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidConnectionsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidConnectionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidHttpconnectionsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidHttpconnectionsServiceURL = new StringBuilder("/api/virtualservice/{uuid}/httpconnections/");
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
            GetVirtualserviceUuidHttpconnectionsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidHttpconnectionsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidHttpconnectionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidHttpconnectionsDetailAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidHttpconnectionsDetailServiceURL = new StringBuilder("/api/virtualservice/{uuid}/httpconnections/detail/");
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
            GetVirtualserviceUuidHttpconnectionsDetailServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidHttpconnectionsDetailServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidHttpconnectionsDetailServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidHttpstatsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidHttpstatsServiceURL = new StringBuilder("/api/virtualservice/{uuid}/httpstats/");
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
            GetVirtualserviceUuidHttpstatsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidHttpstatsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidHttpstatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidAuthstatsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidAuthstatsServiceURL = new StringBuilder("/api/virtualservice/{uuid}/authstats/");
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
            GetVirtualserviceUuidAuthstatsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidAuthstatsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidAuthstatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidHttppolicysetAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidHttppolicysetServiceURL = new StringBuilder("/api/virtualservice/{uuid}/httppolicyset/");
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
            GetVirtualserviceUuidHttppolicysetServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidHttppolicysetServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidHttppolicysetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidHttppolicysetstatsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidHttppolicysetstatsServiceURL = new StringBuilder("/api/virtualservice/{uuid}/httppolicysetstats/");
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
            GetVirtualserviceUuidHttppolicysetstatsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidHttppolicysetstatsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidHttppolicysetstatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidDnspolicystatsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidDnspolicystatsServiceURL = new StringBuilder("/api/virtualservice/{uuid}/dnspolicystats/");
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
            GetVirtualserviceUuidDnspolicystatsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidDnspolicystatsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidDnspolicystatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidNetworksecuritypolicystatsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidNetworksecuritypolicystatsServiceURL = new StringBuilder("/api/virtualservice/{uuid}/networksecuritypolicystats/");
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
            GetVirtualserviceUuidNetworksecuritypolicystatsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidNetworksecuritypolicystatsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidNetworksecuritypolicystatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidNetworksecuritypolicyDetailAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidNetworksecuritypolicyDetailServiceURL = new StringBuilder("/api/virtualservice/{uuid}/networksecuritypolicy/detail/");
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
            GetVirtualserviceUuidNetworksecuritypolicyDetailServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidNetworksecuritypolicyDetailServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidNetworksecuritypolicyDetailServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidCandidatesehostlistAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidCandidatesehostlistServiceURL = new StringBuilder("/api/virtualservice/{uuid}/candidatesehostlist/");
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
            GetVirtualserviceUuidCandidatesehostlistServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidCandidatesehostlistServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidCandidatesehostlistServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidPlacementAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidPlacementServiceURL = new StringBuilder("/api/virtualservice/{uuid}/placement/");
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
            GetVirtualserviceUuidPlacementServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidPlacementServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidPlacementServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidKeyvalAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidKeyvalServiceURL = new StringBuilder("/api/virtualservice/{uuid}/keyval/");
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
            GetVirtualserviceUuidKeyvalServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidKeyvalServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidKeyvalServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidKeyvalsummaryAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidKeyvalsummaryServiceURL = new StringBuilder("/api/virtualservice/{uuid}/keyvalsummary/");
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
            GetVirtualserviceUuidKeyvalsummaryServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidKeyvalsummaryServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidKeyvalsummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidKeyvalsummaryobjsyncAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidKeyvalsummaryobjsyncServiceURL = new StringBuilder("/api/virtualservice/{uuid}/keyvalsummaryobjsync/");
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
            GetVirtualserviceUuidKeyvalsummaryobjsyncServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidKeyvalsummaryobjsyncServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidKeyvalsummaryobjsyncServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidKeyvaldispatchAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidKeyvaldispatchServiceURL = new StringBuilder("/api/virtualservice/{uuid}/keyvaldispatch/");
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
            GetVirtualserviceUuidKeyvaldispatchServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidKeyvaldispatchServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidKeyvaldispatchServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidSslsessioncacheAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidSslsessioncacheServiceURL = new StringBuilder("/api/virtualservice/{uuid}/sslsessioncache/");
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
            GetVirtualserviceUuidSslsessioncacheServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidSslsessioncacheServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidSslsessioncacheServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidCltrackAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidCltrackServiceURL = new StringBuilder("/api/virtualservice/{uuid}/cltrack/");
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
            GetVirtualserviceUuidCltrackServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidCltrackServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidCltrackServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidCltracksummaryAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidCltracksummaryServiceURL = new StringBuilder("/api/virtualservice/{uuid}/cltracksummary/");
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
            GetVirtualserviceUuidCltracksummaryServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidCltracksummaryServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidCltracksummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidClientAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidClientServiceURL = new StringBuilder("/api/virtualservice/{uuid}/client/");
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
            GetVirtualserviceUuidClientServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidClientServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidClientServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidClientsummaryAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidClientsummaryServiceURL = new StringBuilder("/api/virtualservice/{uuid}/clientsummary/");
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
            GetVirtualserviceUuidClientsummaryServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidClientsummaryServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidClientsummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidDnstableAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidDnstableServiceURL = new StringBuilder("/api/virtualservice/{uuid}/dnstable/");
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
            GetVirtualserviceUuidDnstableServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidDnstableServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidDnstableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidGslbservicedetailAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidGslbservicedetailServiceURL = new StringBuilder("/api/virtualservice/{uuid}/gslbservicedetail/");
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
            GetVirtualserviceUuidGslbservicedetailServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidGslbservicedetailServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidGslbservicedetailServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidGslbserviceinternalAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidGslbserviceinternalServiceURL = new StringBuilder("/api/virtualservice/{uuid}/gslbserviceinternal/");
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
            GetVirtualserviceUuidGslbserviceinternalServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidGslbserviceinternalServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidGslbserviceinternalServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidGslbservicealgostatAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidGslbservicealgostatServiceURL = new StringBuilder("/api/virtualservice/{uuid}/gslbservicealgostat/");
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
            GetVirtualserviceUuidGslbservicealgostatServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidGslbservicealgostatServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidGslbservicealgostatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidGslbservicehmonstatAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidGslbservicehmonstatServiceURL = new StringBuilder("/api/virtualservice/{uuid}/gslbservicehmonstat/");
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
            GetVirtualserviceUuidGslbservicehmonstatServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidGslbservicehmonstatServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidGslbservicehmonstatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidGeolocationinfoAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidGeolocationinfoServiceURL = new StringBuilder("/api/virtualservice/{uuid}/geolocationinfo/");
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
            GetVirtualserviceUuidGeolocationinfoServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidGeolocationinfoServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidGeolocationinfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidGeodbinternalAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidGeodbinternalServiceURL = new StringBuilder("/api/virtualservice/{uuid}/geodbinternal/");
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
            GetVirtualserviceUuidGeodbinternalServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidGeodbinternalServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidGeodbinternalServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidGslbsiteinternalAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidGslbsiteinternalServiceURL = new StringBuilder("/api/virtualservice/{uuid}/gslbsiteinternal/");
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
            GetVirtualserviceUuidGslbsiteinternalServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidGslbsiteinternalServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidGslbsiteinternalServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidUserdefineddatascriptcountersAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidUserdefineddatascriptcountersServiceURL = new StringBuilder("/api/virtualservice/{uuid}/userdefineddatascriptcounters/");
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
            GetVirtualserviceUuidUserdefineddatascriptcountersServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidUserdefineddatascriptcountersServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidUserdefineddatascriptcountersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidL4policysetstatsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidL4policysetstatsServiceURL = new StringBuilder("/api/virtualservice/{uuid}/l4policysetstats/");
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
            GetVirtualserviceUuidL4policysetstatsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidL4policysetstatsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidL4policysetstatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidSescaleoutstatusAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidSescaleoutstatusServiceURL = new StringBuilder("/api/virtualservice/{uuid}/sescaleoutstatus/");
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
            GetVirtualserviceUuidSescaleoutstatusServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidSescaleoutstatusServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidSescaleoutstatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidScaleoutstatusAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidScaleoutstatusServiceURL = new StringBuilder("/api/virtualservice/{uuid}/scaleoutstatus/");
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
            GetVirtualserviceUuidScaleoutstatusServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidScaleoutstatusServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidScaleoutstatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidScaleoutstatusDetailAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidScaleoutstatusDetailServiceURL = new StringBuilder("/api/virtualservice/{uuid}/scaleoutstatus/detail/");
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
            GetVirtualserviceUuidScaleoutstatusDetailServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidScaleoutstatusDetailServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidScaleoutstatusDetailServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidSsopolicystatsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidSsopolicystatsServiceURL = new StringBuilder("/api/virtualservice/{uuid}/ssopolicystats/");
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
            GetVirtualserviceUuidSsopolicystatsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidSsopolicystatsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidSsopolicystatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidIcapstatsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidIcapstatsServiceURL = new StringBuilder("/api/virtualservice/{uuid}/icapstats/");
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
            GetVirtualserviceUuidIcapstatsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidIcapstatsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidIcapstatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidOutofbandstatsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidOutofbandstatsServiceURL = new StringBuilder("/api/virtualservice/{uuid}/outofbandstats/");
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
            GetVirtualserviceUuidOutofbandstatsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidOutofbandstatsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidOutofbandstatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidBotstatsAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidBotstatsServiceURL = new StringBuilder("/api/virtualservice/{uuid}/botstats/");
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
            GetVirtualserviceUuidBotstatsServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidBotstatsServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidBotstatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidPlacementSummaryAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidPlacementSummaryServiceURL = new StringBuilder("/api/virtualservice/{uuid}/placement/summary/");
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
            GetVirtualserviceUuidPlacementSummaryServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidPlacementSummaryServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidPlacementSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidPlacementDetailAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidPlacementDetailServiceURL = new StringBuilder("/api/virtualservice/{uuid}/placement/detail/");
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
            GetVirtualserviceUuidPlacementDetailServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidPlacementDetailServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidPlacementDetailServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> GetVirtualserviceUuidPlacementStatusAsync(string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            
            
            
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetVirtualserviceUuidPlacementStatusServiceURL = new StringBuilder("/api/virtualservice/{uuid}/placement/status/");
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
            GetVirtualserviceUuidPlacementStatusServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVirtualserviceUuidPlacementStatusServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetVirtualserviceUuidPlacementStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
