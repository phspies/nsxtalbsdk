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
    public class NSXTALBConfigActionDetailsType 
    {
        /// <summary>
        /// Name of the action.
        /// </summary>
        [JsonProperty(PropertyName = "action_name")]
        public string? ActionName { get; set; }
        /// <summary>
        /// Error message if request failed.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Parameter data.
        /// </summary>
        [JsonProperty(PropertyName = "parameter_data")]
        public string? ParameterData { get; set; }
        /// <summary>
        /// API path.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string? Path { get; set; }
        /// <summary>
        /// Name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "resource_name")]
        public string? ResourceName { get; set; }
        /// <summary>
        /// Config type of the resource.
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
