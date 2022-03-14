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
    public class NSXTALBSeMgrEventDetailsType 
    {
        public NSXTALBSeMgrEventDetailsType()
        {
        }
        /// <summary>
        /// cloud_name of SeMgrEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_name")]
        public string? CloudName { get; set; }
        /// <summary>
        /// Unique object identifier of cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_uuid")]
        public string? CloudUuid { get; set; }
        /// <summary>
        /// enable_state of SeMgrEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "enable_state")]
        public string? EnableState { get; set; }
        /// <summary>
        /// Placeholder for description of property gcp_info of obj type SeMgrEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "gcp_info")]
        public NSXTALBGcpInfoType GcpInfo { get; set; }
        /// <summary>
        /// host_name of SeMgrEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "host_name")]
        public string? HostName { get; set; }
        /// <summary>
        /// Unique object identifier of host.
        /// </summary>
        [JsonProperty(PropertyName = "host_uuid")]
        public string? HostUuid { get; set; }
        /// <summary>
        /// Number of memory.
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public int? Memory { get; set; }
        /// <summary>
        /// migrate_state of SeMgrEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "migrate_state")]
        public string? MigrateState { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "new_mgmt_ip")]
        public string? NewMgmtIp { get; set; }
        /// <summary>
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "new_mgmt_ip6")]
        public string? NewMgmtIp6 { get; set; }
        /// <summary>
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "old_mgmt_ip")]
        public string? OldMgmtIp { get; set; }
        /// <summary>
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "old_mgmt_ip6")]
        public string? OldMgmtIp6 { get; set; }
        /// <summary>
        /// reason of SeMgrEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// se_grp_name of SeMgrEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_grp_name")]
        public string? SeGrpName { get; set; }
        /// <summary>
        /// Unique object identifier of se_grp.
        /// </summary>
        [JsonProperty(PropertyName = "se_grp_uuid")]
        public string? SeGrpUuid { get; set; }
        /// <summary>
        /// Number of vcpus.
        /// </summary>
        [JsonProperty(PropertyName = "vcpus")]
        public int? Vcpus { get; set; }
        /// <summary>
        /// vs_name of SeMgrEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name")]
        public IList<string> VsName { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public IList<string> VsUuid { get; set; }
        /// <summary>
        /// vSphere HA on cluster enabled. Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vsphere_ha_enabled")]
        public bool? VsphereHaEnabled { get; set; }
        /// <summary>
        /// This flag is set to true when Cloud Connector has detected an ESX host failure. This flag is set to false when the SE
        /// connects back to the controller, or when vSphere HA recovery timeout has occurred. Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vsphere_ha_inprogress")]
        public bool? VsphereHaInprogress { get; set; }
    }
}
