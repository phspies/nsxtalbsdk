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
    public class NSXTALBSeBootupCompressionPropertiesType 
    {
        /// <summary>
        /// Number of buffers to use for compression output.
        /// </summary>
        [JsonProperty(PropertyName = "buf_num")]
        public int? BufNum { get; set; }
        /// <summary>
        /// Size of each buffer used for compression output, this should ideally be a multiple of pagesize.
        /// </summary>
        [JsonProperty(PropertyName = "buf_size")]
        public int? BufSize { get; set; }
        /// <summary>
        /// hash size used by compression, rounded to the last power of 2.
        /// </summary>
        [JsonProperty(PropertyName = "hash_size")]
        public int? HashSize { get; set; }
        /// <summary>
        /// Level of compression to apply on content selected for aggressive compression.
        /// </summary>
        [JsonProperty(PropertyName = "level_aggressive")]
        public int? LevelAggressive { get; set; }
        /// <summary>
        /// Level of compression to apply on content selected for normal compression.
        /// </summary>
        [JsonProperty(PropertyName = "level_normal")]
        public int? LevelNormal { get; set; }
        /// <summary>
        /// window size used by compression, rounded to the last power of 2.
        /// </summary>
        [JsonProperty(PropertyName = "window_size")]
        public int? WindowSize { get; set; }
    }
}
