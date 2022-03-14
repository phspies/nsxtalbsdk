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
    public class NSXTALBContentLibConfigType 
    {
        public NSXTALBContentLibConfigType()
        {
        }
        /// <summary>
        /// Content Library Id. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Content Library name. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
