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
    public class NSXTALBGslbDnsGeoUpdateType 
    {
        /// <summary>
        /// GslbGeoDbProfile object that is pushed on on a per Dns basis. Field deprecated in 18.1.5, 18.2.1. Field introduced in
        /// 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "obj_info")]
        public IList<NSXTALBGslbObjectInfoType> ObjInfo { get; set; }
        /// <summary>
        /// Enum options - GSLB_NONE, GSLB_CREATE, GSLB_UPDATE, GSLB_DELETE, GSLB_PURGE, GSLB_DECL. Field deprecated in 18.1.5,
        /// 18.2.1. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ops")]
        public string? Ops { get; set; }
        /// <summary>
        /// Field deprecated in 18.1.5, 18.2.1. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_list")]
        public IList<string> SeList { get; set; }
    }
}
