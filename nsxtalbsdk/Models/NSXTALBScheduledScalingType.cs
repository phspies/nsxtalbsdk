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
    public class NSXTALBScheduledScalingType 
    {
        /// <summary>
        /// Scheduled autoscale duration (in hours). Allowed values are 1-24. Field introduced in 21.1.1. Unit is HOURS.
        /// </summary>
        [JsonProperty(PropertyName = "autoscaling_duration")]
        public int? AutoscalingDuration { get; set; }
        /// <summary>
        /// The cron expression describing desired time for the scheduled autoscale. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cron_expression")]
        public string? CronExpression { get; set; }
        /// <summary>
        /// Desired number of servers during scheduled intervals, it may cause scale-in or scale-out based on the value. Field
        /// introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "desired_capacity")]
        public int? DesiredCapacity { get; set; }
        /// <summary>
        /// Enables the scheduled autoscale. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Scheduled autoscale end date in ISO8601 format, said day will be included in scheduled and have to be in future and
        /// greater than start date. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "end_date")]
        public string? EndDate { get; set; }
        /// <summary>
        /// Deprecated.Frequency of the Scheduled autoscale. Enum options - ONCE, EVERY_DAY, EVERY_WEEK, EVERY_MONTH. Field
        /// deprecated in 21.1.3. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "recurrence")]
        public string? Recurrence { get; set; }
        /// <summary>
        /// Maximum number of simultaneous scale-in/out servers for scheduled autoscale. If this value is 0, regular autoscale
        /// policy dictates this. . Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "schedule_max_step")]
        public int? ScheduleMaxStep { get; set; }
        /// <summary>
        /// Scheduled autoscale start date in ISO8601 format, said day will be included in scheduled and have to be in future. Field
        /// introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "start_date")]
        public string? StartDate { get; set; }
    }
}
