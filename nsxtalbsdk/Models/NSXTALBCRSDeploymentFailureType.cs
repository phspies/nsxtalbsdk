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
    public class NSXTALBCRSDeploymentFailureType 
    {
        /// <summary>
        /// List of all CRS updates that failed to install. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "crs_info")]
        public IList<NSXTALBCRSDetailsType> CrsInfo { get; set; }
        /// <summary>
        /// Error message to be conveyed to controller UI. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
    }
}
