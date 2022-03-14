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
    public class NSXTALBRebalanceScaleinEventDetailsType 
    {
        public NSXTALBRebalanceScaleinEventDetailsType()
        {
        }
        /// <summary>
        /// Placeholder for description of property scalein_params of obj type RebalanceScaleinEventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "scalein_params")]
        public NSXTALBVsScaleinParamsType ScaleinParams { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VsUuid { get; set; }
    }
}
