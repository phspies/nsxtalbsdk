using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDNSRegisterInfoType
    {
        /// <summary>
        /// Placeholder for description of property dns_info of obj type DNSRegisterInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "dns_info")]
        public IList<NSXTALBDnsInfoType> DnsInfo { get; set; }
        /// <summary>
        /// error of DNSRegisterInfo.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
        /// <summary>
        /// Placeholder for description of property fip of obj type DNSRegisterInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "fip")]
        public NSXTALBIpAddrType Fip { get; set; }
        /// <summary>
        /// Number of total_records.
        /// </summary>
        [JsonProperty(PropertyName = "total_records")]
        public int? TotalRecords { get; set; }
        /// <summary>
        /// Placeholder for description of property vip of obj type DNSRegisterInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vip")]
        public NSXTALBIpAddrType Vip { get; set; }
        /// <summary>
        /// vip_id of DNSRegisterInfo.
        /// </summary>
        [JsonProperty(PropertyName = "vip_id")]
        public string? VipId { get; set; }
        /// <summary>
        /// vs_names of DNSRegisterInfo.
        /// </summary>
        [JsonProperty(PropertyName = "vs_names")]
        public IList<string> VsNames { get; set; }
        /// <summary>
        /// Unique object identifiers of vss.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuids")]
        public IList<string> VsUuids { get; set; }
    }
}
