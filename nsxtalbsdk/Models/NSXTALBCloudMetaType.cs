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
    public class NSXTALBCloudMetaType 
    {
        public NSXTALBCloudMetaType()
        {
        }
        /// <summary>
        /// key of CloudMeta.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Key { get; set; }
        /// <summary>
        /// value of CloudMeta.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Value { get; set; }
    }
}
