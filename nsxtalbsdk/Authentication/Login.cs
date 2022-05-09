using Newtonsoft.Json;
using nsxtalbsdk.Models;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace nsxtalbsdk.Modules
{
    public class AuthenticationHelper
    {
        public static async Task<RestResponse<LoginResponseType>> LoginAsync(LoginRequestType credentials, RestClient restClient, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            StringBuilder GetAlertServiceURL = new StringBuilder("/login");
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = GetAlertServiceURL.ToString();
            request.AddJsonBody(credentials);
            RestResponse<LoginResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<LoginResponseType>(request, _cancellationToken, _timeout, _retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "Login operation to " + GetAlertServiceURL.ToString() + " did not complete successfully";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response;
        }
        public static async Task
        Logout(RestClient restClient)
        {
            StringBuilder PostLogoutURL = new StringBuilder("/logout");
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = PostLogoutURL.ToString();
            RestResponse response = await restClient.PostAsync(request);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "logout operation to " + PostLogoutURL.ToString() + " did not complete successfully";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
        }
    }
}
