using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTPLocalFileType
    {
        /// <summary>
        /// Mime-type of the content in the file.
        /// </summary>
        [JsonProperty(PropertyName = "content_type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ContentType { get; set; }
        /// <summary>
        /// File content to used in the local HTTP response body.
        /// </summary>
        [JsonProperty(PropertyName = "file_content")]
        [System.ComponentModel.DataAnnotations.Required]
        public string FileContent { get; set; }
        /// <summary>
        /// File content length. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "file_length")]
        public int? FileLength { get; set; }
    }
}
