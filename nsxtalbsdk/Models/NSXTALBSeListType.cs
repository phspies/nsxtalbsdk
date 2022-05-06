using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeListType
    {
        /// <summary>
        /// Vip is Active on Cloud. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "active_on_cloud")]
        public bool? ActiveOnCloud { get; set; }
        /// <summary>
        /// Vip is Active on this ServiceEngine. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "active_on_se")]
        public bool? ActiveOnSe { get; set; }
        /// <summary>
        /// This flag is set when scaling in an SE in admin down mode.
        /// </summary>
        [JsonProperty(PropertyName = "admin_down_requested")]
        public bool? AdminDownRequested { get; set; }
        /// <summary>
        /// Indicates if an SE is at the current version. This state will now be derived from SE Group runtime. Field deprecated in
        /// 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "at_curr_ver")]
        public bool? AtCurrVer { get; set; }
        /// <summary>
        /// Attach IP is in progress. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "attach_ip_in_progress")]
        public bool? AttachIpInProgress { get; set; }
        /// <summary>
        /// This field indicates the status of programming network reachability to the Virtual Service IP in the cloud. Field
        /// deprecated in 21.1.3. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "attach_ip_status")]
        public string? AttachIpStatus { get; set; }
        /// <summary>
        /// This flag indicates if network reachability to the Virtual Service IP in the cloud has been successfully programmed.
        /// Field deprecated in 21.1.3. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "attach_ip_success")]
        public bool? AttachIpSuccess { get; set; }
        /// <summary>
        /// All attempts to program the Vip on Cloud have been made. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_programming_done")]
        public bool? CloudProgrammingDone { get; set; }
        /// <summary>
        /// Status of Vip on the Cloud. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_programming_status")]
        public string? CloudProgrammingStatus { get; set; }
        /// <summary>
        /// This flag is set when an SE is admin down or scaling in.
        /// </summary>
        [JsonProperty(PropertyName = "delete_in_progress")]
        public bool? DeleteInProgress { get; set; }
        /// <summary>
        /// Detach IP is in progress. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "detach_ip_in_progress")]
        public bool? DetachIpInProgress { get; set; }
        /// <summary>
        /// This field is not needed with the current implementation of Update RPCs to SEs. Field deprecated in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "download_selist_only")]
        public bool? DownloadSelistOnly { get; set; }
        /// <summary>
        /// Placeholder for description of property floating_intf_ip of obj type SeList field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "floating_intf_ip")]
        public IList<NSXTALBIpAddrType> FloatingIntfIp { get; set; }
        /// <summary>
        /// This flag indicates whether the geo-files have been pushed to the DNS-VS's SE. No longer used, replaced by SE DataStore.
        /// Field deprecated in 18.1.5, 18.2.1. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "geo_download")]
        public bool? GeoDownload { get; set; }
        /// <summary>
        /// This flag indicates whether the geodb object has been pushed to the DNS-VS's SE. No longer used, replaced by SE
        /// DataStore. Field deprecated in 18.1.5, 18.2.1. Field introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "geodb_download")]
        public bool? GeodbDownload { get; set; }
        /// <summary>
        /// This flag indicates whether the gslb, ghm, gs objects have been pushed to the DNS-VS's SE. No longer used, replaced by
        /// SE DataStore. Field deprecated in 18.1.5, 18.2.1. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_download")]
        public bool? GslbDownload { get; set; }
        /// <summary>
        /// Updated whenever this entry is created. When the sees this has changed, it means that the SE should disrupt, since there
        /// was a delete then create, not an update. Field introduced in 18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "incarnation")]
        public string? Incarnation { get; set; }
        /// <summary>
        /// This flag was used to display the SE connected state. This state will now be derived from SE Group runtime. Field
        /// deprecated in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "is_connected")]
        public bool? IsConnected { get; set; }
        /// <summary>
        /// Placeholder for description of property is_portchannel of obj type SeList field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_portchannel")]
        public bool? IsPortchannel { get; set; }
        /// <summary>
        /// Placeholder for description of property is_primary of obj type SeList field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_primary")]
        public bool? IsPrimary { get; set; }
        /// <summary>
        /// Placeholder for description of property is_standby of obj type SeList field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_standby")]
        public bool? IsStandby { get; set; }
        /// <summary>
        /// Number of memory.
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public int? Memory { get; set; }
        /// <summary>
        /// Management IPv4 address of SE. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_ip")]
        public NSXTALBIpAddrType MgmtIp { get; set; }
        /// <summary>
        /// Management IPv6 address of SE. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_ip6")]
        public NSXTALBIpAddrType MgmtIp6 { get; set; }
        /// <summary>
        /// This field is not needed with the current implementation of Update RPCs to SEs. Field deprecated in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "pending_download")]
        public bool? PendingDownload { get; set; }
        /// <summary>
        /// SE scaling in status is determined by delete_in_progress. Field deprecated in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "scalein_in_progress")]
        public bool? ScaleinInProgress { get; set; }
        /// <summary>
        /// This flag is set when a VS is actively scaling out to this SE. Field introduced in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "scaleout_in_progress")]
        public bool? ScaleoutInProgress { get; set; }
        /// <summary>
        /// All attempts to program the Vip on this ServiceEngine have been made. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_programming_done")]
        public bool? SeProgrammingDone { get; set; }
        /// <summary>
        /// Vip is awaiting response from this ServiceEngine. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_ready_in_progress")]
        public bool? SeReadyInProgress { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SeRef { get; set; }
        /// <summary>
        /// Number of sec_idx.
        /// </summary>
        [JsonProperty(PropertyName = "sec_idx")]
        public int? SecIdx { get; set; }
        /// <summary>
        /// Placeholder for description of property snat_ip of obj type SeList field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "snat_ip")]
        public NSXTALBIpAddrType SnatIp { get; set; }
        /// <summary>
        /// Number of vcpus.
        /// </summary>
        [JsonProperty(PropertyName = "vcpus")]
        public int? Vcpus { get; set; }
        /// <summary>
        /// Version of the SE. This state will now be derived from SE Group runtime. Field deprecated in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vip6_subnet_mask")]
        public int? Vip6SubnetMask { get; set; }
        /// <summary>
        /// Placeholder for description of property vip_intf_ip of obj type SeList field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vip_intf_ip")]
        public NSXTALBIpAddrType VipIntfIp { get; set; }
        /// <summary>
        /// Placeholder for description of property vip_intf_list of obj type SeList field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vip_intf_list")]
        public IList<NSXTALBSeVipInterfaceListType> VipIntfList { get; set; }
        /// <summary>
        /// vip_intf_mac of SeList.
        /// </summary>
        [JsonProperty(PropertyName = "vip_intf_mac")]
        public string? VipIntfMac { get; set; }
        /// <summary>
        /// Number of vip_subnet_mask.
        /// </summary>
        [JsonProperty(PropertyName = "vip_subnet_mask")]
        public int? VipSubnetMask { get; set; }
        /// <summary>
        /// Number of vlan_id.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_id")]
        public int? VlanId { get; set; }
        /// <summary>
        /// Placeholder for description of property vnic of obj type SeList field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vnic")]
        public IList<NSXTALBVsSeVnicType> Vnic { get; set; }
    }
}
