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
    public class NSXTALBWafApplicationSignatureProviderType 
    {
        public NSXTALBWafApplicationSignatureProviderType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Available application names and the ruleset version, when the rules for an application changed the last time. Field
        /// introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "available_applications")]
        public IList<NSXTALBWafApplicationSignatureAppVersionType> AvailableApplications { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// The error message indicating why the last update check failed. Field deprecated in 20.1.3. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "last_check_for_updates_error")]
        public string? LastCheckForUpdatesError { get; set; }
        /// <summary>
        /// The last time that we checked for updates but did not get a result because of an error. Field deprecated in 20.1.3.
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "last_failed_check_for_updates")]
        public NSXTALBTimeStampType LastFailedCheckForUpdates { get; set; }
        /// <summary>
        /// The last time that we checked for updates sucessfully. Field deprecated in 20.1.3. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "last_successful_check_for_updates")]
        public NSXTALBTimeStampType LastSuccessfulCheckForUpdates { get; set; }
        /// <summary>
        /// Name of Application Specific Ruleset Provider. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Version of signatures. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ruleset_version")]
        public string? RulesetVersion { get; set; }
        /// <summary>
        /// If this object is managed by the Application Signatures update  service, this field contain the status of this
        /// syncronization. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "service_status")]
        public NSXTALBWebApplicationSignatureServiceStatusType ServiceStatus { get; set; }
        /// <summary>
        /// The WAF rules. Not visible in the API. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "signatures")]
        public IList<NSXTALBWafRuleType> Signatures { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
