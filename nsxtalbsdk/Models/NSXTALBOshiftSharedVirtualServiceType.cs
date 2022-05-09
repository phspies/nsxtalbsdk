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
    public class NSXTALBOshiftSharedVirtualServiceType 
    {
        /// <summary>
        /// Name of shared virtualservice. VirtualService will be created automatically by Cloud Connector. Field introduced in
        /// 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "virtualservice_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VirtualserviceName { get; set; }
    }
}
