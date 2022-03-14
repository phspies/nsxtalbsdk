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
    public class NSXTALBMetricsDataType 
    {
        /// <summary>
        /// Placeholder for description of property application_response_time of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "application_response_time")]
        public double? ApplicationResponseTime { get; set; }
        /// <summary>
        /// Placeholder for description of property blocking_time of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "blocking_time")]
        public double? BlockingTime { get; set; }
        /// <summary>
        /// Placeholder for description of property browser_rendering_time of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "browser_rendering_time")]
        public double? BrowserRenderingTime { get; set; }
        /// <summary>
        /// Placeholder for description of property client_rtt of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "client_rtt")]
        public double? ClientRtt { get; set; }
        /// <summary>
        /// Placeholder for description of property connection_time of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "connection_time")]
        public double? ConnectionTime { get; set; }
        /// <summary>
        /// Placeholder for description of property dns_lookup_time of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "dns_lookup_time")]
        public double? DnsLookupTime { get; set; }
        /// <summary>
        /// Placeholder for description of property dom_content_load_time of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "dom_content_load_time")]
        public double? DomContentLoadTime { get; set; }
        /// <summary>
        /// Placeholder for description of property is_null of obj type MetricsData field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_null")]
        public bool? IsNull { get; set; }
        /// <summary>
        /// Number of num_samples.
        /// </summary>
        [JsonProperty(PropertyName = "num_samples")]
        public int? NumSamples { get; set; }
        /// <summary>
        /// Placeholder for description of property page_download_time of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "page_download_time")]
        public double? PageDownloadTime { get; set; }
        /// <summary>
        /// Placeholder for description of property page_load_time of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "page_load_time")]
        public double? PageLoadTime { get; set; }
        /// <summary>
        /// Placeholder for description of property prediction_interval_high of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "prediction_interval_high")]
        public double? PredictionIntervalHigh { get; set; }
        /// <summary>
        /// Placeholder for description of property prediction_interval_low of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "prediction_interval_low")]
        public double? PredictionIntervalLow { get; set; }
        /// <summary>
        /// Placeholder for description of property redirection_time of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "redirection_time")]
        public double? RedirectionTime { get; set; }
        /// <summary>
        /// Placeholder for description of property rum_client_data_transfer_time of obj type MetricsData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "rum_client_data_transfer_time")]
        public double? RumClientDataTransferTime { get; set; }
        /// <summary>
        /// Placeholder for description of property server_rtt of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "server_rtt")]
        public double? ServerRtt { get; set; }
        /// <summary>
        /// Placeholder for description of property service_time of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "service_time")]
        public double? ServiceTime { get; set; }
        /// <summary>
        /// timestamp of MetricsData.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public string? Timestamp { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public double Value { get; set; }
        /// <summary>
        /// Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "value_str")]
        public string? ValueStr { get; set; }
        /// <summary>
        /// Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "value_str_desc")]
        public string? ValueStrDesc { get; set; }
        /// <summary>
        /// Placeholder for description of property waiting_time of obj type MetricsData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "waiting_time")]
        public double? WaitingTime { get; set; }
    }
}
