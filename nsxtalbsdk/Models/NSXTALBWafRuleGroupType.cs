using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBWafRuleGroupType
    {
        /// <summary>
        /// Enable or disable WAF Rule Group. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enable { get; set; }
        /// <summary>
        /// Exclude list for the WAF rule group. The fields in the exclude list entry are logically and'ed to deduce the exclusion
        /// criteria. If there are multiple excludelist entries, it will be 'logical or' of them. Field introduced in 17.2.1.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_list")]
        public IList<NSXTALBWafExcludeListEntryType> ExcludeList { get; set; }
        /// <summary>
        /// When set to 'true', any rule in this group will not cause 'deny' or 'redirect' actions to run, even if WAF Policy is set
        /// to enforcement mode. The behavior would be as if this rule operated in detection mode regardless of WAF Policy setting.
        /// Field deprecated in 18.1.5. Field introduced in 18.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "force_detection")]
        public bool? ForceDetection { get; set; }
        /// <summary>
        /// Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Rules as per Modsec language. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBWafRuleType> Rules { get; set; }
    }
}
