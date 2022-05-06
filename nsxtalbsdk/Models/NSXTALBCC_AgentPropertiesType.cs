using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCC_AgentPropertiesType
    {
        /// <summary>
        /// Maximum polls to check for async jobs to finish.
        /// </summary>
        [JsonProperty(PropertyName = "async_retries")]
        public int? AsyncRetries { get; set; }
        /// <summary>
        /// Delay between each async job status poll check. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "async_retries_delay")]
        public int? AsyncRetriesDelay { get; set; }
        /// <summary>
        /// Discovery poll target duration; a scale factor of 1+ is computed with the actual discovery (actual/target) and used to
        /// tweak slow and fast poll intervals. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "poll_duration_target")]
        public int? PollDurationTarget { get; set; }
        /// <summary>
        /// Fast poll interval. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "poll_fast_target")]
        public int? PollFastTarget { get; set; }
        /// <summary>
        /// Slow poll interval. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "poll_slow_target")]
        public int? PollSlowTarget { get; set; }
        /// <summary>
        /// Maximum polls to check for vnics to be attached to VM.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_retries")]
        public int? VnicRetries { get; set; }
        /// <summary>
        /// Delay between each vnic status poll check. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_retries_delay")]
        public int? VnicRetriesDelay { get; set; }
    }
}
