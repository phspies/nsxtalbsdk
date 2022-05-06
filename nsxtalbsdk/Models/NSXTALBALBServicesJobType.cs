using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBALBServicesJobType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// The command to be triggered by the albservicesjob. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Command { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// The time at which the albservicesjob is ended. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public NSXTALBTimeStampType EndTime { get; set; }
        /// <summary>
        /// The name of the albservicesjob. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// A unique identifier for this job entry on the Pulse portal. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pulse_job_id")]
        public string? PulseJobId { get; set; }
        /// <summary>
        /// The time at which the albservicesjob is started. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public NSXTALBTimeStampType StartTime { get; set; }
        /// <summary>
        /// The status of the albservicesjob. Enum options - UNDETERMINED, PENDING, IN_PROGRESS, COMPLETED, FAILED. Field introduced
        /// in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// The unique identifier of the tenant to which this albservicesjob belongs. It is a reference to an object of type Tenant.
        /// Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// A unique identifier for this albservicesjob entry. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
