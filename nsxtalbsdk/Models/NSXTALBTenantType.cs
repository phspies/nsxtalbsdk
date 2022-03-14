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
    public class NSXTALBTenantType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Placeholder for description of property config_settings of obj type Tenant field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "config_settings")]
        public NSXTALBTenantConfigurationType ConfigSettings { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Creator of this tenant.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// The referred label groups are enforced on the tenant if this is set to true.If this is set to false, the label groups
        /// are suggested for the tenant. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "enforce_label_group")]
        public bool? EnforceLabelGroup { get; set; }
        /// <summary>
        /// The label_groups to be enforced on the tenant. This is strictly enforced only if enforce_label_group is set to True. It
        /// is a reference to an object of type LabelGroup. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "label_group_refs")]
        public IList<string> LabelGroupRefs { get; set; }
        /// <summary>
        /// Placeholder for description of property local of obj type Tenant field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "local")]
        public bool? Local { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Suggestive pool of key value pairs for recommending assignment of labels to objects in the User Interface. Every entry
        /// is unique in both key and value. Field deprecated in 20.1.5. Field introduced in 20.1.2. Maximum of 256 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "suggested_object_labels")]
        public IList<NSXTALBTenantLabelType> SuggestedObjectLabels { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
