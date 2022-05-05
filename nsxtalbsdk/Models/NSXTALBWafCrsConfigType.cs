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
    public class NSXTALBWafCrsConfigType 
    {
        /// <summary>
        /// Enable to automatically download new WAF signatures/CRS version to the Controller. Field introduced in 21.1.1. Allowed
        /// in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise(Allowed values- false)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_auto_download_waf_signatures")]
        public bool? EnableAutoDownloadWafSignatures { get; set; }
        /// <summary>
        /// Enable event notifications when new WAF signatures/CRS versions are available. Field introduced in 21.1.1. Allowed in
        /// Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition. Special default for
        /// Basic edition is false, Essentials edition is false, Enterprise is True.
        /// </summary>
        [JsonProperty(PropertyName = "enable_waf_signatures_notifications")]
        public bool? EnableWafSignaturesNotifications { get; set; }
    }
}
