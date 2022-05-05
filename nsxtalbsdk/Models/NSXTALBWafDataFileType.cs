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
    public class NSXTALBWafDataFileType 
    {
        /// <summary>
        /// Stringified WAF File Data. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Data { get; set; }
        /// <summary>
        /// WAF Data File Name. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// WAF data file type. Enum options - WAF_DATAFILE_PM_FROM_FILE, WAF_DATAFILE_DTD, WAF_DATAFILE_XSD. Field introduced in
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
