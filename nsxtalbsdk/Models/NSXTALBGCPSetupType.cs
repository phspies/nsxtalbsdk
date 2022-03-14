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
    public class NSXTALBGCPSetupType 
    {
        public NSXTALBGCPSetupType()
        {
        }
        /// <summary>
        /// cc_id of GCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// hostname of GCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// network of GCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string? Network { get; set; }
        /// <summary>
        /// nhop_inst of GCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "nhop_inst")]
        public string? NhopInst { get; set; }
        /// <summary>
        /// Placeholder for description of property nhop_ip of obj type GCPSetup field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "nhop_ip")]
        public NSXTALBIpAddrType NhopIp { get; set; }
        /// <summary>
        /// project of GCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "project")]
        public string? Project { get; set; }
        /// <summary>
        /// reason of GCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// route_name of GCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "route_name")]
        public string? RouteName { get; set; }
        /// <summary>
        /// subnet of GCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public string? Subnet { get; set; }
        /// <summary>
        /// Placeholder for description of property vip of obj type GCPSetup field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vip")]
        public NSXTALBIpAddrType Vip { get; set; }
        /// <summary>
        /// vs_name of GCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name")]
        public string? VsName { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
        /// <summary>
        /// zone of GCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "zone")]
        public string? Zone { get; set; }
    }
}
