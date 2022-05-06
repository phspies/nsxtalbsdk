using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBProactiveSupportDefaultsType
    {
        /// <summary>
        /// Opt-in to attach core dump with support case. Field introduced in 20.1.1. Allowed in Basic(Allowed values- false)
        /// edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "attach_core_dump")]
        public bool? AttachCoreDump { get; set; }
        /// <summary>
        /// Opt-in to attach tech support with support case. Field introduced in 20.1.1. Allowed in Basic(Allowed values- false)
        /// edition, Essentials(Allowed values- false) edition, Enterprise edition. Special default for Basic edition is false,
        /// Essentials edition is false, Enterprise is True.
        /// </summary>
        [JsonProperty(PropertyName = "attach_tech_support")]
        public bool? AttachTechSupport { get; set; }
        /// <summary>
        /// Case severity to be used for proactive support case creation. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "case_severity")]
        public string? CaseSeverity { get; set; }
    }
}
