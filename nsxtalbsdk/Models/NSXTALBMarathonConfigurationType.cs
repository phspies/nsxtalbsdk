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
    public class NSXTALBMarathonConfigurationType 
    {
        /// <summary>
        /// Framework tag to be used in Virtualservice name. Default is framework name from Mesos. If this tag is altered atruntime,
        /// Virtualservices will be deleted and re-created.
        /// </summary>
        [JsonProperty(PropertyName = "framework_tag")]
        public string? FrameworkTag { get; set; }
        /// <summary>
        /// Password for Marathon authentication.
        /// </summary>
        [JsonProperty(PropertyName = "marathon_password")]
        public string? MarathonPassword { get; set; }
        /// <summary>
        /// Marathon API URL of the form http //host port.
        /// </summary>
        [JsonProperty(PropertyName = "marathon_url")]
        public string? MarathonUrl { get; set; }
        /// <summary>
        /// Username for Marathon authentication.
        /// </summary>
        [JsonProperty(PropertyName = "marathon_username")]
        public string? MarathonUsername { get; set; }
        /// <summary>
        /// Private port range allocated to this Marathon framework instance.
        /// </summary>
        [JsonProperty(PropertyName = "private_port_range")]
        public NSXTALBPortRangeType PrivatePortRange { get; set; }
        /// <summary>
        /// Public port range allocated to this Marathon framework instance.
        /// </summary>
        [JsonProperty(PropertyName = "public_port_range")]
        public NSXTALBPortRangeType PublicPortRange { get; set; }
        /// <summary>
        /// Tenant to pin this Marathon instance to. If set, a tenant object will be created in Avi bearing this name and all
        /// applications created in this marathon will be associated with this tenant regardless of, if any, tenant configuration in
        /// marathon label for this application.
        /// </summary>
        [JsonProperty(PropertyName = "tenant")]
        public string? Tenant { get; set; }
        /// <summary>
        /// Use Token based authentication instead of basic authentication. Token is refreshed every 5 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "use_token_auth")]
        public bool? UseTokenAuth { get; set; }
        /// <summary>
        /// Tag VS name with framework name or framework_tag. Useful in deployments with multiple frameworks.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name_tag_framework")]
        public bool? VsNameTagFramework { get; set; }
    }
}
