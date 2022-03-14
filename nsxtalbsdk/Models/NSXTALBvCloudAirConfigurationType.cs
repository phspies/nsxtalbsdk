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
    public class NSXTALBvCloudAirConfigurationType 
    {
        public NSXTALBvCloudAirConfigurationType()
        {
        }
        /// <summary>
        /// vCloudAir access mode. Enum options - NO_ACCESS, READ_ACCESS, WRITE_ACCESS.
        /// </summary>
        [JsonProperty(PropertyName = "privilege", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Privilege { get; set; }
        /// <summary>
        /// vCloudAir host address.
        /// </summary>
        [JsonProperty(PropertyName = "vca_host", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaHost { get; set; }
        /// <summary>
        /// vCloudAir instance ID.
        /// </summary>
        [JsonProperty(PropertyName = "vca_instance", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaInstance { get; set; }
        /// <summary>
        /// vCloudAir management network.
        /// </summary>
        [JsonProperty(PropertyName = "vca_mgmt_network", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaMgmtNetwork { get; set; }
        /// <summary>
        /// vCloudAir orgnization ID.
        /// </summary>
        [JsonProperty(PropertyName = "vca_orgnization", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaOrgnization { get; set; }
        /// <summary>
        /// vCloudAir password.
        /// </summary>
        [JsonProperty(PropertyName = "vca_password", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaPassword { get; set; }
        /// <summary>
        /// vCloudAir username.
        /// </summary>
        [JsonProperty(PropertyName = "vca_username", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaUsername { get; set; }
        /// <summary>
        /// vCloudAir virtual data center name.
        /// </summary>
        [JsonProperty(PropertyName = "vca_vdc", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaVdc { get; set; }
    }
}
