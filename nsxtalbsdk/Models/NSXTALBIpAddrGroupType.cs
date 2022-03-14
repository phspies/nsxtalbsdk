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
    public class NSXTALBIpAddrGroupType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Configure IP address(es).
        /// </summary>
        [JsonProperty(PropertyName = "addrs")]
        public IList<NSXTALBIpAddrType> Addrs { get; set; }
        /// <summary>
        /// Populate IP addresses from members of this Cisco APIC EPG. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_epg_name")]
        public string? ApicEpgName { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Populate the IP address ranges from the geo database for this country.
        /// </summary>
        [JsonProperty(PropertyName = "country_codes")]
        public IList<string> CountryCodes { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Configure (IP address, port) tuple(s).
        /// </summary>
        [JsonProperty(PropertyName = "ip_ports")]
        public IList<NSXTALBIpAddrPortType> IpPorts { get; set; }
        /// <summary>
        /// Key value pairs for granular object access control. Also allows for classification and tagging of similar objects. Field
        /// deprecated in 20.1.5. Field introduced in 20.1.2. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueType> Labels { get; set; }
        /// <summary>
        /// Populate IP addresses from tasks of this Marathon app.
        /// </summary>
        [JsonProperty(PropertyName = "marathon_app_name")]
        public string? MarathonAppName { get; set; }
        /// <summary>
        /// Task port associated with marathon service port. If Marathon app has multiple service ports, this is required. Else, the
        /// first task port is used.
        /// </summary>
        [JsonProperty(PropertyName = "marathon_service_port")]
        public int? MarathonServicePort { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Name of the IP address group.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Configure IP address prefix(es).
        /// </summary>
        [JsonProperty(PropertyName = "prefixes")]
        public IList<NSXTALBIpAddrPrefixType> Prefixes { get; set; }
        /// <summary>
        /// Configure IP address range(s).
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<NSXTALBIpAddrRangeType> Ranges { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the IP address group.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
