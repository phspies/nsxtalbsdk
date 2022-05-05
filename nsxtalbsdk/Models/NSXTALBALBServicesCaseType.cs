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
    public class NSXTALBALBServicesCaseType 
    {
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "asset_id")]
        public string? AssetId { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "case_attachments")]
        public IList<NSXTALBALBServicesCaseAttachmentType> CaseAttachments { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "case_created_by")]
        public string? CaseCreatedBy { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "case_number")]
        public string? CaseNumber { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "case_status")]
        public string? CaseStatus { get; set; }
        /// <summary>
        /// Contact information associated to particular case. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "contact_info")]
        public NSXTALBALBServicesUserType ContactInfo { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "created_date")]
        public string? CreatedDate { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "custom_tag")]
        public string? CustomTag { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_environment")]
        public string? DeploymentEnvironment { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Email of the point of contact for a particular support case. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string? Email { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "environment")]
        public string? Environment { get; set; }
        /// <summary>
        /// Business justification for a feature request. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "fr_business_justification")]
        public string? FrBusinessJustification { get; set; }
        /// <summary>
        /// Current solution/workaround for a feature request. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "fr_current_solution")]
        public string? FrCurrentSolution { get; set; }
        /// <summary>
        /// Expected date of delivery for a feature request in YYYY-MM-DD format. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "fr_timing")]
        public string? FrTiming { get; set; }
        /// <summary>
        /// Possible use cases for a feature request. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "fr_use_cases")]
        public string? FrUseCases { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "last_modified_date")]
        public string? LastModifiedDate { get; set; }
        /// <summary>
        /// Stores the ALB services configuration mode. Enum options - MODE_UNKNOWN, SALESFORCE, SYSTEST, MYVMWARE. Field introduced
        /// in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string? Mode { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "patch_version")]
        public string? PatchVersion { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string? Severity { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string? Subject { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public string? Time { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
