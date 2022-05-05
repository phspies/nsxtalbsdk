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
    public class NSXTALBImageCloudDataType 
    {
        /// <summary>
        /// Cloud Data specific to a particular cloud. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_data_values")]
        public IList<NSXTALBImageCloudSpecificDataType> CloudDataValues { get; set; }
        /// <summary>
        /// Contains the name of the cloud. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_name")]
        public string? CloudName { get; set; }
    }
}
