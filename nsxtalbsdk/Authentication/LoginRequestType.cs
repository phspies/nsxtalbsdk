using Newtonsoft.Json;
namespace nsxtalbsdk.Models
{
    public class LoginRequestType
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
