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
    public class NSXTALBAppInfoType 
    {
        public NSXTALBAppInfoType()
        {
        }
        /// <summary>
        /// app_hdr_name of AppInfo.
        /// </summary>
        [JsonProperty(PropertyName = "app_hdr_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string AppHdrName { get; set; }
        /// <summary>
        /// app_hdr_value of AppInfo.
        /// </summary>
        [JsonProperty(PropertyName = "app_hdr_value", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string AppHdrValue { get; set; }
    }
}
