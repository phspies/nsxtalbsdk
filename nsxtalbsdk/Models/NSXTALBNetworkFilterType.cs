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
    public class NSXTALBNetworkFilterType 
    {
        public NSXTALBNetworkFilterType()
        {
        }
        /// <summary>
        /// It is a reference to an object of type VIMgrNWRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "network_ref", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string NetworkRef { get; set; }
        /// <summary>
        /// server_filter of NetworkFilter.
        /// </summary>
        [JsonProperty(PropertyName = "server_filter")]
        public string? ServerFilter { get; set; }
    }
}
