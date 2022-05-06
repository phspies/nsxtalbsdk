using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBLicenseLedgerDetailsType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Maintain information about reservation against cookie. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "escrow_infos")]
        public IList<NSXTALBLicenseInfoType> EscrowInfos { get; set; }
        /// <summary>
        /// Maintain information about consumed licenses against se_uuid. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_infos")]
        public IList<NSXTALBLicenseInfoType> SeInfos { get; set; }
        /// <summary>
        /// License usage per tier. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tier_usages")]
        public IList<NSXTALBLicenseTierUsageType> TierUsages { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Uuid for reference. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
