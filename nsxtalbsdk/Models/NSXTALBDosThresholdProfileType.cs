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
    public class NSXTALBDosThresholdProfileType 
    {
        /// <summary>
        /// Attack type, min and max values for DoS attack detection.
        /// </summary>
        [JsonProperty(PropertyName = "thresh_info")]
        public IList<NSXTALBDosThresholdType> ThreshInfo { get; set; }
        /// <summary>
        /// Timer value in seconds to collect DoS attack metrics based on threshold on the Service Engine for this Virtual Service.
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "thresh_period", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int ThreshPeriod { get; set; }
    }
}
