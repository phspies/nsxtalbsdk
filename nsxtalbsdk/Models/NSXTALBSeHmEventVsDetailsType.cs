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
    public class NSXTALBSeHmEventVsDetailsType 
    {
        public NSXTALBSeHmEventVsDetailsType()
        {
        }
        /// <summary>
        /// HA Compromised reason.
        /// </summary>
        [JsonProperty(PropertyName = "ha_reason")]
        public string? HaReason { get; set; }
        /// <summary>
        /// Reason for Virtual Service Down.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Service Engine name.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// UUID of the event generator.
        /// </summary>
        [JsonProperty(PropertyName = "src_uuid")]
        public string? SrcUuid { get; set; }
        /// <summary>
        /// VIP address.
        /// </summary>
        [JsonProperty(PropertyName = "vip6_address")]
        public NSXTALBIpAddrType Vip6Address { get; set; }
        /// <summary>
        /// VIP address.
        /// </summary>
        [JsonProperty(PropertyName = "vip_address")]
        public NSXTALBIpAddrType VipAddress { get; set; }
        /// <summary>
        /// VIP id.
        /// </summary>
        [JsonProperty(PropertyName = "vip_id")]
        public string? VipId { get; set; }
        /// <summary>
        /// Virtual Service name. It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_service")]
        public string? VirtualService { get; set; }
    }
}
