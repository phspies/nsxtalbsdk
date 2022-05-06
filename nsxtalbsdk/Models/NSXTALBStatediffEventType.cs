using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBStatediffEventType
    {
        /// <summary>
        /// Time taken to complete Statediff event in seconds. Field introduced in 21.1.3. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }
        /// <summary>
        /// Task end time. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public string? EndTime { get; set; }
        /// <summary>
        /// Statediff event message if any. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// Task start time. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public string? StartTime { get; set; }
        /// <summary>
        /// Statediff event status. Enum options - FB_INIT, FB_IN_PROGRESS, FB_COMPLETED, FB_FAILED, FB_COMPLETED_WITH_ERRORS. Field
        /// introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// Name of Statediff task. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "task_name")]
        public string? TaskName { get; set; }
    }
}
