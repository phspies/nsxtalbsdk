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
    public class NSXTALBSeHmEventGslbPoolDetailsType 
    {
        /// <summary>
        /// GslbService Pool name.
        /// </summary>
        [JsonProperty(PropertyName = "gsgroup")]
        public string? Gsgroup { get; set; }
        /// <summary>
        /// Gslb service name. It is a reference to an object of type GslbService.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_service")]
        public string? GslbService { get; set; }
        /// <summary>
        /// GslbService member details.
        /// </summary>
        [JsonProperty(PropertyName = "gsmember")]
        public NSXTALBSeHmEventGslbPoolMemberDetailsType Gsmember { get; set; }
        /// <summary>
        /// HA Compromised reason.
        /// </summary>
        [JsonProperty(PropertyName = "ha_reason")]
        public string? HaReason { get; set; }
        /// <summary>
        /// Service Engine.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// UUID of the event generator.
        /// </summary>
        [JsonProperty(PropertyName = "src_uuid")]
        public string? SrcUuid { get; set; }
    }
}
