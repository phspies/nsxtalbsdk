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
        public static async Task<IRestResponse<LoginResponseType>> LoginAsync(LoginRequestType credentials, RestClient restClient, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            StringBuilder GetAlertServiceURL = new StringBuilder("/login");
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.Resource = GetAlertServiceURL.ToString();
            request.AddJsonBody(credentials);
            IRestResponse<LoginResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<LoginResponseType>(request, _cancellationToken, _timeout, _retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "Login operation to " + GetAlertServiceURL.ToString() + " did not complete successfully";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response;
        }
        public static void Logout(List<RestResponseCookie> sessionCookies, RestClient restClient)
        {
            StringBuilder PostLogoutURL = new StringBuilder("/logout");
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            sessionCookies.ForEach(x =>
            {
                request.AddCookie(x.Name, x.Value);
            });
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            request.Resource = PostLogoutURL.ToString();
            IRestResponse response = restClient.Post(request);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "logout operation to " + PostLogoutURL.ToString() + " did not complete successfully";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
        }
    }
}
