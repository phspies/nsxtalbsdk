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
    public class NSXTALBGslbStatusType 
    {
        public NSXTALBGslbStatusType()
        {
        }
        /// <summary>
        /// details of GslbStatus.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<string> Details { get; set; }
        /// <summary>
        /// Placeholder for description of property gslb_runtime of obj type GslbStatus field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "gslb_runtime")]
        public NSXTALBGslbRuntimeType GslbRuntime { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "site")]
        public NSXTALBGslbSiteRuntimeType Site { get; set; }
        /// <summary>
        /// Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "third_party_site")]
        public NSXTALBGslbThirdPartySiteRuntimeType ThirdPartySite { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
