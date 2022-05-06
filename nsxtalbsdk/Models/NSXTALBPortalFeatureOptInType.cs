using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBPortalFeatureOptInType
    {
        /// <summary>
        /// Enable to receive Application specific signature updates. Field introduced in 20.1.4. Allowed in Basic(Allowed values-
        /// false) edition, Essentials(Allowed values- false) edition, Enterprise(Allowed values- false) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_appsignature_sync")]
        public bool? EnableAppsignatureSync { get; set; }
        /// <summary>
        /// Enable to receive IP reputation updates. Field introduced in 20.1.1. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_ip_reputation")]
        public bool? EnableIpReputation { get; set; }
        /// <summary>
        /// Enable Pulse Case Management. Field introduced in 21.1.1. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise(Allowed values- false) edition, Enterprise edition. Special
        /// default for Basic edition is false, Essentials edition is false, Enterprise edition is false, Enterprise is True.
        /// </summary>
        [JsonProperty(PropertyName = "enable_pulse_case_management")]
        public bool? EnablePulseCaseManagement { get; set; }
        /// <summary>
        /// Enable to receive WAF CRS updates. Field introduced in 21.1.1. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise(Allowed values- false) edition, Enterprise edition. Special
        /// default for Basic edition is false, Essentials edition is false, Enterprise edition is false, Enterprise is True.
        /// </summary>
        [JsonProperty(PropertyName = "enable_pulse_waf_management")]
        public bool? EnablePulseWafManagement { get; set; }
        /// <summary>
        /// Enable to receive Bot Management updates. Field introduced in 21.1.1. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_user_agent_db_sync")]
        public bool? EnableUserAgentDbSync { get; set; }
    }
}
