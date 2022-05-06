using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCaptureFileSizeType
    {
        /// <summary>
        /// Maximum size in MB. Set 0 for avi default size. Allowed values are 100-512000. Special values are 0 - AVI_DEFAULT. Field
        /// introduced in 18.2.8. Unit is MB.
        /// </summary>
        [JsonProperty(PropertyName = "absolute_size")]
        public int? AbsoluteSize { get; set; }
        /// <summary>
        /// Limits capture to percentage of free disk space. Set 0 for avi default size. Allowed values are 0-75. Field introduced
        /// in 18.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "percentage_size")]
        public int? PercentageSize { get; set; }
    }
}
