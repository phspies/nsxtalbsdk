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
    public class ClusterRuntime
    {
        RestClient restClient;
        CancellationToken cancellationToken;
        int timeout;
        int retry;
        string defaultXAviVerion;
        List<Cookie> sessionCookies;
        public ClusterRuntime(RestClient Client, List<Cookie> _sessionCookies, CancellationToken _cancellationToken, int _timeout, int _retry, string _defaultXAviVerion)
        {
            restClient = Client;
            cancellationToken = _cancellationToken;
            retry = _retry;
            timeout = _timeout;
            defaultXAviVerion = _defaultXAviVerion;
            sessionCookies = _sessionCookies;
        }
        public async Task<ClusterRuntimeType> GetRuntimeAsync(string? XAviTenant = null, string? XAviTenantUUID = null, string? XAviVersion = null)
        {
            if (XAviVersion == null) { XAviVersion = defaultXAviVerion; }
            StringBuilder GetAlbservicesfileuploadServiceURL = new StringBuilder("/api/cluster/runtime");
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.AddHeader("Content-type", "application/json");
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XAviVersion != null) request.AddHeader("X-Avi-Version", XAviVersion);
            request.Resource = GetAlbservicesfileuploadServiceURL.ToString();
            RestResponse<ClusterRuntimeType> response = await restClient.ExecuteTaskAsyncWithPolicy<ClusterRuntimeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP GET operation to " + GetAlbservicesfileuploadServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
    }
}
