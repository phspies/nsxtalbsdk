using nsxtalbsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHardwareSecurityModuleType 
    {
        public NSXTALBHardwareSecurityModuleType()
        {
        }
        /// <summary>
        /// AWS CloudHSM specific configuration. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "cloudhsm")]
        public NSXTALBHSMAwsCloudHsmType Cloudhsm { get; set; }
        /// <summary>
        /// Thales netHSM specific configuration.
        /// </summary>
        [JsonProperty(PropertyName = "nethsm")]
        public IList<NSXTALBHSMThalesNetHsmType> Nethsm { get; set; }
        /// <summary>
        /// Thales Remote File Server (RFS), used for the netHSMs, configuration.
        /// </summary>
        [JsonProperty(PropertyName = "rfs")]
        public NSXTALBHSMThalesRFSType Rfs { get; set; }
        /// <summary>
        /// Safenet/Gemalto Luna/Gem specific configuration.
        /// </summary>
        [JsonProperty(PropertyName = "sluna")]
        public NSXTALBHSMSafenetLunaType Sluna { get; set; }
        /// <summary>
        /// HSM type to use. Enum options - HSM_TYPE_THALES_NETHSM, HSM_TYPE_SAFENET_LUNA, HSM_TYPE_AWS_CLOUDHSM.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
