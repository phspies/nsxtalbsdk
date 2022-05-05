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
    public class NSXTALBTencentSetupType 
    {
        /// <summary>
        /// Tencent Cloud id. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// Tencent error message. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// Tencent Region id. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string? Region { get; set; }
        /// <summary>
        /// Tencent VPC id. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "vpc_id")]
        public string? VpcId { get; set; }
    }
}
