using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAzureServicePrincipalCredentialsType
    {
        /// <summary>
        /// Application Id created for Avi Controller. Required for application id based authentication only. Field introduced in
        /// 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "application_id")]
        public string? ApplicationId { get; set; }
        /// <summary>
        /// Authentication token created for the Avi Controller application. Required for application id based authentication only.
        /// Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "authentication_token")]
        public string? AuthenticationToken { get; set; }
        /// <summary>
        /// Tenant ID for the subscription. Required for application id based authentication only. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_id")]
        public string? TenantId { get; set; }
    }
}
