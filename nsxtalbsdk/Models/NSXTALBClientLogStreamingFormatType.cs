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
    public class NSXTALBClientLogStreamingFormatType 
    {
        public NSXTALBClientLogStreamingFormatType()
        {
        }
        /// <summary>
        /// Format for the streamed logs. Enum options - LOG_STREAMING_FORMAT_JSON_FULL, LOG_STREAMING_FORMAT_JSON_SELECTED. Field
        /// introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "format", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Format { get; set; }
        /// <summary>
        /// List of log fields to be streamed, when selective fields (LOG_STREAMING_FORMAT_JSON_SELECTED) option is chosen. Only
        /// top-level fields in application or connection logs are supported. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "included_fields")]
        public IList<string> IncludedFields { get; set; }
    }
}
