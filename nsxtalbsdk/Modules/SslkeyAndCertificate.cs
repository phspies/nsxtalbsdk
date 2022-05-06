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
    public class SslkeyAndCertificate
    {
        private RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        private string defaultXAviVerion;
        private List<RestResponseCookie> sessionCookies;
        public SslkeyAndCertificate(RestClient Client, List<RestResponseCookie> _sessionCookies, CancellationToken _cancellationToken, int _timeout, int _retry, string _defaultXAviVerion)
        {
            restClient = Client;
            cancellationToken = _cancellationToken;
            retry = _retry;
            timeout = _timeout;
            defaultXAviVerion = _defaultXAviVerion;
            sessionCookies = _sessionCookies;
        }
        public async Task<NSXTALBSSLKeyAndCertificateApiResponseType> GetSslkeyandcertificateAsync(string? Name = null, string? RefersTo = null, string? ReferredBy = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            StringBuilder GetSslkeyandcertificateServiceURL = new StringBuilder("/api/sslkeyandcertificate");
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
            request.Resource = GetSslkeyandcertificateServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBSSLKeyAndCertificateApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSLKeyAndCertificateApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP GET operation to " + GetSslkeyandcertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<NSXTALBSSLKeyAndCertificateType> PostSslkeyandcertificateAsync(NSXTALBSSLKeyAndCertificateType Body, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            StringBuilder PostSslkeyandcertificateServiceURL = new StringBuilder("/api/sslkeyandcertificate");
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
            request.Resource = PostSslkeyandcertificateServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBSSLKeyAndCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSLKeyAndCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP POST operation to " + PostSslkeyandcertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<NSXTALBSSLKeyAndCertificateType> GetSslkeyandcertificateUuidAsync(string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? Fields = null, bool? IncludeName = null, bool? SkipDefault = null, string? JoinSubresources = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetSslkeyandcertificateUuidServiceURL = new StringBuilder("/api/sslkeyandcertificate/{uuid}");
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
            GetSslkeyandcertificateUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (Fields != null) { request.AddQueryParameter("fields", JsonConvert.ToString(Fields).ToLowerString()); }
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", JsonConvert.ToString(SkipDefault).ToLowerString()); }
            if (JoinSubresources != null) { request.AddQueryParameter("join_subresources", JsonConvert.ToString(JoinSubresources).ToLowerString()); }
            request.Resource = GetSslkeyandcertificateUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBSSLKeyAndCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSLKeyAndCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP GET operation to " + GetSslkeyandcertificateUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<NSXTALBSSLKeyAndCertificateType> PutSslkeyandcertificateUuidAsync(NSXTALBSSLKeyAndCertificateType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PutSslkeyandcertificateUuidServiceURL = new StringBuilder("/api/sslkeyandcertificate/{uuid}");
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
            PutSslkeyandcertificateUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PutSslkeyandcertificateUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBSSLKeyAndCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSLKeyAndCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP PUT operation to " + PutSslkeyandcertificateUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<NSXTALBSSLKeyAndCertificateType> PatchSslkeyandcertificateUuidAsync(NSXTALBSSLKeyAndCertificateType Body, string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PatchSslkeyandcertificateUuidServiceURL = new StringBuilder("/api/sslkeyandcertificate/{uuid}");
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
            PatchSslkeyandcertificateUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PatchSslkeyandcertificateUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBSSLKeyAndCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSLKeyAndCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP PATCH operation to " + PatchSslkeyandcertificateUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<string> DeleteSslkeyandcertificateUuidAsync(string Uuid, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder DeleteSslkeyandcertificateUuidServiceURL = new StringBuilder("/api/sslkeyandcertificate/{uuid}");
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
            DeleteSslkeyandcertificateUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteSslkeyandcertificateUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP DELETE operation to " + DeleteSslkeyandcertificateUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<string> PostSslkeyandcertificateUuidRenewAsync(string Body, string Uuid, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder PostSslkeyandcertificateUuidRenewServiceURL = new StringBuilder("/api/sslkeyandcertificate/{uuid}/renew");
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
            PostSslkeyandcertificateUuidRenewServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PostSslkeyandcertificateUuidRenewServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP POST operation to " + PostSslkeyandcertificateUuidRenewServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
    }
}
