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
    public class NSXTALBSeGeoDbDetailsType 
    {
        /// <summary>
        /// Geo Db file name.
        /// </summary>
        [JsonProperty(PropertyName = "file_name")]
        public string? FileName { get; set; }
        /// <summary>
        /// Name of the Gslb Geo Db Profile.
        /// </summary>
        [JsonProperty(PropertyName = "geo_db_profile_name")]
        public string? GeoDbProfileName { get; set; }
        /// <summary>
        /// UUID of the Gslb Geo Db Profile. It is a reference to an object of type GslbGeoDbProfile.
        /// </summary>
        [JsonProperty(PropertyName = "geo_db_profile_ref")]
        public string? GeoDbProfileRef { get; set; }
        /// <summary>
        /// Reason for Gslb Geo Db failure. Enum options - NO_ERROR, FILE_ERROR, FILE_FORMAT_ERROR, FILE_NO_RESOURCES.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// UUID of the SE responsible for this event. It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref")]
        public string? SeRef { get; set; }
        /// <summary>
        /// VIP id.
        /// </summary>
        [JsonProperty(PropertyName = "vip_id")]
        public string? VipId { get; set; }
        /// <summary>
        /// Virtual Service name. It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_service")]
        public string? VirtualService { get; set; }
    }
}
