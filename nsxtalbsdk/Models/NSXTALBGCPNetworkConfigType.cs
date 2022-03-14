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
    public class NSXTALBGCPNetworkConfigType 
    {
        /// <summary>
        /// Config Mode for Google Cloud network configuration. Enum options - INBAND_MANAGEMENT, ONE_ARM_MODE, TWO_ARM_MODE. Field
        /// introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "config", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Config { get; set; }
        /// <summary>
        /// Configure InBand Management as Google Cloud network configuration. In this configuration the data network and management
        /// network for Service Engines will be same. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "inband")]
        public NSXTALBGCPInBandManagementType Inband { get; set; }
        /// <summary>
        /// Configure One Arm Mode as Google Cloud network configuration. In this configuration the data network and the management
        /// network for the Service Engines will be separated. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "one_arm")]
        public NSXTALBGCPOneArmModeType OneArm { get; set; }
        /// <summary>
        /// Configure Two Arm Mode as Google Cloud network configuration. In this configuration the frontend data network, backend
        /// data network and the management network for the Service Engines will be separated. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "two_arm")]
        public NSXTALBGCPTwoArmModeType TwoArm { get; set; }
    }
}
