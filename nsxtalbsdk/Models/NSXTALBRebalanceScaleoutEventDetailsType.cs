using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBRebalanceScaleoutEventDetailsType
    {
        /// <summary>
        /// Placeholder for description of property scaleout_params of obj type RebalanceScaleoutEventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "scaleout_params")]
        public NSXTALBVsScaleoutParamsType ScaleoutParams { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VsUuid { get; set; }
    }
}
