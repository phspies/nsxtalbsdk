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
    public class NSXTALBAlertType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Output of the alert action script.
        /// </summary>
        [JsonProperty(PropertyName = "action_script_output")]
        public string? ActionScriptOutput { get; set; }
        /// <summary>
        /// It is a reference to an object of type AlertConfig.
        /// </summary>
        [JsonProperty(PropertyName = "alert_config_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AlertConfigRef { get; set; }
        /// <summary>
        /// Placeholder for description of property app_events of obj type Alert field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "app_events")]
        public IList<NSXTALBApplicationLogType> AppEvents { get; set; }
        /// <summary>
        /// Placeholder for description of property conn_events of obj type Alert field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "conn_events")]
        public IList<NSXTALBConnectionLogType> ConnEvents { get; set; }
        /// <summary>
        /// alert generation criteria.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// List of event pages this alert is associated with.
        /// </summary>
        [JsonProperty(PropertyName = "event_pages")]
        public IList<string> EventPages { get; set; }
        /// <summary>
        /// Placeholder for description of property events of obj type Alert field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<NSXTALBEventLogType> Events { get; set; }
        /// <summary>
        /// Unix Timestamp of the last throttling in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "last_throttle_timestamp")]
        public double? LastThrottleTimestamp { get; set; }
        /// <summary>
        /// Resolved Alert Type. Enum options - ALERT_LOW, ALERT_MEDIUM, ALERT_HIGH.
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Level { get; set; }
        /// <summary>
        /// Placeholder for description of property metric_info of obj type Alert field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "metric_info")]
        public IList<NSXTALBMetricLogType> MetricInfo { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// UUID of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "obj_key")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ObjKey { get; set; }
        /// <summary>
        /// Name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "obj_name")]
        public string? ObjName { get; set; }
        /// <summary>
        /// UUID of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "obj_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ObjUuid { get; set; }
        /// <summary>
        /// reason of Alert.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// related uuids for the connection log. Only Log agent needs to fill this. Server uuid should be in
        /// formatpool_uuid-ip-port. In case of no port is set for server it shouldstill be operational port for the server.
        /// </summary>
        [JsonProperty(PropertyName = "related_uuids")]
        public IList<string> RelatedUuids { get; set; }
        /// <summary>
        /// State of the alert. It would be active when createdIt would be changed to state read when read by the admin. Enum
        /// options - ALERT_STATE_ON, ALERT_STATE_DISMISSED, ALERT_STATE_THROTTLED.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [System.ComponentModel.DataAnnotations.Required]
        public string State { get; set; }
        /// <summary>
        /// summary of alert based on alert config.
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Summary { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Number of threshold.
        /// </summary>
        [JsonProperty(PropertyName = "threshold")]
        public int? Threshold { get; set; }
        /// <summary>
        /// Number of times it was throttled.
        /// </summary>
        [JsonProperty(PropertyName = "throttle_count")]
        public int? ThrottleCount { get; set; }
        /// <summary>
        /// Unix Timestamp of the last throttling in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        [System.ComponentModel.DataAnnotations.Required]
        public double Timestamp { get; set; }
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
