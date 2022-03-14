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
    public class NSXTALBVipSeAssignedType 
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
        /// Placeholder for description of property admin_down_requested of obj type VipSeAssigned field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "admin_down_requested")]
        public bool? AdminDownRequested { get; set; }
        /// <summary>
        /// Attach IP is in progress. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "attach_ip_in_progress")]
        public bool? AttachIpInProgress { get; set; }
        /// <summary>
        /// Placeholder for description of property connected of obj type VipSeAssigned field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "connected")]
        public bool? Connected { get; set; }
        /// <summary>
        /// Detach IP is in progress. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "detach_ip_in_progress")]
        public bool? DetachIpInProgress { get; set; }
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
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Placeholder for description of property oper_status of obj type VipSeAssigned field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "oper_status")]
        public NSXTALBOperationalStatusType OperStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property primary of obj type VipSeAssigned field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "primary")]
        public bool? Primary { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
        /// <summary>
        /// Placeholder for description of property scalein_in_progress of obj type VipSeAssigned field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "scalein_in_progress")]
        public bool? ScaleinInProgress { get; set; }
        /// <summary>
        /// Vip is awaiting scaleout response from this ServiceEngine. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "scaleout_in_progress")]
        public bool? ScaleoutInProgress { get; set; }
        /// <summary>
        /// Vip is awaiting response from this ServiceEngine. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_ready_in_progress")]
        public bool? SeReadyInProgress { get; set; }
        /// <summary>
        /// Placeholder for description of property snat_ip of obj type VipSeAssigned field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "snat_ip")]
        public NSXTALBIpAddrType SnatIp { get; set; }
        /// <summary>
        /// Placeholder for description of property standby of obj type VipSeAssigned field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "standby")]
        public bool? Standby { get; set; }
    }
}
