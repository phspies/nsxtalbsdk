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
    public class NSXTALBCompressionProfileType 
    {
        /// <summary>
        /// Number of buffers to use for compression output. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "buf_num")]
        public int? BufNum { get; set; }
        /// <summary>
        /// Size of each buffer used for compression output, this should ideally be a multiple of pagesize. Field introduced in
        /// 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "buf_size")]
        public int? BufSize { get; set; }
        /// <summary>
        /// Compress only content types listed in this string group. Content types not present in this list are not compressed. It
        /// is a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "compressible_content_ref")]
        public string? CompressibleContentRef { get; set; }
        /// <summary>
        /// Compress HTTP response content if it wasn't already compressed.
        /// </summary>
        [JsonProperty(PropertyName = "compression", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Compression { get; set; }
        /// <summary>
        /// Custom filters used when auto compression is not selected.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public IList<NSXTALBCompressionFilterType> Filter { get; set; }
        /// <summary>
        /// hash size used by compression, rounded to the last power of 2. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "hash_size")]
        public int? HashSize { get; set; }
        /// <summary>
        /// Level of compression to apply on content selected for aggressive compression. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "level_aggressive")]
        public int? LevelAggressive { get; set; }
        /// <summary>
        /// Level of compression to apply on content selected for normal compression. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "level_normal")]
        public int? LevelNormal { get; set; }
        /// <summary>
        /// If client RTT is higher than this threshold, enable normal compression on the response. Field introduced in 21.1.1. Unit
        /// is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "max_low_rtt")]
        public int? MaxLowRtt { get; set; }
        /// <summary>
        /// If client RTT is higher than this threshold, enable aggressive compression on the response.  . Field introduced in
        /// 21.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "min_high_rtt")]
        public int? MinHighRtt { get; set; }
        /// <summary>
        /// Minimum response content length to enable compression. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "min_length")]
        public int? MinLength { get; set; }
        /// <summary>
        /// Values that identify mobile browsers in order to enable aggressive compression. It is a reference to an object of type
        /// StringGroup. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mobile_str_ref")]
        public string? MobileStrRef { get; set; }
        /// <summary>
        /// Offload compression from the servers to AVI. Saves compute cycles on the servers.
        /// </summary>
        [JsonProperty(PropertyName = "remove_accept_encoding_header", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public bool RemoveAcceptEncodingHeader { get; set; }
        /// <summary>
        /// Compress content automatically or add custom filters to define compressible content and compression levels. Enum options
        /// - AUTO_COMPRESSION, CUSTOM_COMPRESSION.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// window size used by compression, rounded to the last power of 2. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "window_size")]
        public int? WindowSize { get; set; }
    }
}
