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
    public class NSXTALBNsxtDatastoresType 
    {
        /// <summary>
        /// List of shared datastores. Field introduced in 20.1.2. Allowed in Basic edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "ds_ids")]
        public IList<string> DsIds { get; set; }
        /// <summary>
        /// Include or Exclude. Field introduced in 20.1.2. Allowed in Basic edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "include")]
        public bool? Include { get; set; }
    }
}
