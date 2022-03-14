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
    public class NSXTALBConfigUpdateDetailsType 
    {
        public NSXTALBConfigUpdateDetailsType()
        {
        }
        /// <summary>
        /// Error message if request failed.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// New updated data of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "new_resource_data")]
        public string? NewResourceData { get; set; }
        /// <summary>
        /// Old & overwritten data of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "old_resource_data")]
        public string? OldResourceData { get; set; }
        /// <summary>
        /// API path.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string? Path { get; set; }
        /// <summary>
        /// Request data if request failed.
        /// </summary>
        [JsonProperty(PropertyName = "request_data")]
        public string? RequestData { get; set; }
        /// <summary>
        /// Name of the created resource.
        /// </summary>
        [JsonProperty(PropertyName = "resource_name")]
        public string? ResourceName { get; set; }
        /// <summary>
        /// Config type of the updated resource.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type")]
        public string? ResourceType { get; set; }
        /// <summary>
        /// Status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// Request user.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
    }
}
