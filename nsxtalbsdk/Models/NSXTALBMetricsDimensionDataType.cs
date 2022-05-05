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
    public class NSXTALBMetricsDimensionDataType 
    {
        /// <summary>
        /// Dimension Type. Enum options - METRICS_DIMENSION_METRIC_TIMESTAMP, METRICS_DIMENSION_COUNTRY, METRICS_DIMENSION_OS,
        /// METRICS_DIMENSION_URL, METRICS_DIMENSION_DEVTYPE, METRICS_DIMENSION_LANG, METRICS_DIMENSION_BROWSER,
        /// METRICS_DIMENSION_IPGROUP, METRICS_DIMENSION_ATTACK, METRICS_DIMENSION_ASN.
        /// </summary>
        [JsonProperty(PropertyName = "dimension")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Dimension { get; set; }
        /// <summary>
        /// Dimension ID.
        /// </summary>
        [JsonProperty(PropertyName = "dimension_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DimensionId { get; set; }
    }
}
