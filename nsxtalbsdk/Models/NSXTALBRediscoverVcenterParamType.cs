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
    public class NSXTALBRediscoverVcenterParamType 
    {
        /// <summary>
        /// cloud of RediscoverVcenterParam.
        /// </summary>
        [JsonProperty(PropertyName = "cloud")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Cloud { get; set; }
    }
}
