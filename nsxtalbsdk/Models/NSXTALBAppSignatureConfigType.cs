using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAppSignatureConfigType
    {
        /// <summary>
        /// Application Signature db sync interval in minutes. Allowed values are 60-10080. Field introduced in 20.1.4. Unit is MIN.
        /// Allowed in Basic edition, Essentials edition, Enterprise edition. Special default for Basic edition is 1440, Essentials
        /// edition is 1440, Enterprise is 1440.
        /// </summary>
        [JsonProperty(PropertyName = "app_signature_sync_interval")]
        public int? AppSignatureSyncInterval { get; set; }
    }
}
