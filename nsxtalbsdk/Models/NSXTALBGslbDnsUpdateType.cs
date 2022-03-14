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
    public class NSXTALBGslbDnsUpdateType 
    {
        /// <summary>
        /// Number of clear_on_max_retries.
        /// </summary>
        [JsonProperty(PropertyName = "clear_on_max_retries")]
        public int? ClearOnMaxRetries { get; set; }
        /// <summary>
        /// List of Geo DB Profiles associated with this DNS VS. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_geo_db_profile_uuids")]
        public IList<string> GslbGeoDbProfileUuids { get; set; }
        /// <summary>
        /// List of Gslb Services associated with the DNS VS. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_service_uuids")]
        public IList<string> GslbServiceUuids { get; set; }
        /// <summary>
        /// Gslb object associated with the DNS VS. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_uuids")]
        public IList<string> GslbUuids { get; set; }
        /// <summary>
        /// Gslb, GslbService objects that is pushed on a per Dns basis. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "obj_info")]
        public IList<NSXTALBGslbObjectInfoType> ObjInfo { get; set; }
        /// <summary>
        /// Number of send_interval.
        /// </summary>
        [JsonProperty(PropertyName = "send_interval")]
        public int? SendInterval { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
