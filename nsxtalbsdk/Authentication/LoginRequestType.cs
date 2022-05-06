using Newtonsoft.Json;
namespace nsxtalbsdk.Authentication
{
    public class LoginRequestType
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
