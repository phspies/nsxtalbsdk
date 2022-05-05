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
    public class NSXTALBAlertRuleType 
    {
        /// <summary>
        /// Placeholder for description of property conn_app_log_rule of obj type AlertRule field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "conn_app_log_rule")]
        public NSXTALBAlertFilterType ConnAppLogRule { get; set; }
        /// <summary>
        /// event_match_filter of AlertRule.
        /// </summary>
        [JsonProperty(PropertyName = "event_match_filter")]
        public string? EventMatchFilter { get; set; }
        /// <summary>
        /// Placeholder for description of property metrics_rule of obj type AlertRule field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "metrics_rule")]
        public IList<NSXTALBAlertRuleMetricType> MetricsRule { get; set; }
        /// <summary>
        /// Enum options - OPERATOR_AND, OPERATOR_OR.
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string? OperatorProperty { get; set; }
        /// <summary>
        /// Placeholder for description of property sys_event_rule of obj type AlertRule field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "sys_event_rule")]
        public IList<NSXTALBAlertRuleEventType> SysEventRule { get; set; }
    }
}
