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
    public class NSXTALBActionGroupConfigType 
    {
        public NSXTALBActionGroupConfigType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// reference of the action script configuration to be used. It is a reference to an object of type AlertScriptConfig.
        /// </summary>
        [JsonProperty(PropertyName = "action_script_config_ref")]
        public string? ActionScriptConfigRef { get; set; }
        /// <summary>
        /// Trigger Notification to AutoScale Manager. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values-
        /// false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "autoscale_trigger_notification")]
        public bool? AutoscaleTriggerNotification { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Select the Email Notification configuration to use when sending alerts via email. It is a reference to an object of type
        /// AlertEmailConfig.
        /// </summary>
        [JsonProperty(PropertyName = "email_config_ref")]
        public string? EmailConfigRef { get; set; }
        /// <summary>
        /// Generate Alert only to external destinations. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed
        /// values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "external_only", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public bool ExternalOnly { get; set; }
        /// <summary>
        /// When an alert is generated, mark its priority via the Alert Level. Enum options - ALERT_LOW, ALERT_MEDIUM, ALERT_HIGH.
        /// </summary>
        [JsonProperty(PropertyName = "level", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Level { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Select the SNMP Trap Notification to use when sending alerts via SNMP Trap. It is a reference to an object of type
        /// SnmpTrapProfile.
        /// </summary>
        [JsonProperty(PropertyName = "snmp_trap_profile_ref")]
        public string? SnmpTrapProfileRef { get; set; }
        /// <summary>
        /// Select the Syslog Notification configuration to use when sending alerts via Syslog. It is a reference to an object of
        /// type AlertSyslogConfig.
        /// </summary>
        [JsonProperty(PropertyName = "syslog_config_ref")]
        public string? SyslogConfigRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
