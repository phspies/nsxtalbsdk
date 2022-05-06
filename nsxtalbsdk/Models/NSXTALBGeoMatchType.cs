using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGeoMatchType
    {
        /// <summary>
        /// The Geo data type to match on. Enum options - ATTRIBUTE_IP_PREFIX, ATTRIBUTE_COUNTRY_CODE, ATTRIBUTE_COUNTRY_NAME,
        /// ATTRIBUTE_CONTINENT_CODE, ATTRIBUTE_CONTINENT_NAME, ATTRIBUTE_REGION_NAME, ATTRIBUTE_CITY_NAME, ATTRIBUTE_ISP_NAME,
        /// ATTRIBUTE_ORGANIZATION_NAME, ATTRIBUTE_AS_NUMBER, ATTRIBUTE_AS_NAME, ATTRIBUTE_LONGITUDE, ATTRIBUTE_LATITUDE,
        /// ATTRIBUTE_CUSTOM_1, ATTRIBUTE_CUSTOM_2, ATTRIBUTE_CUSTOM_3, ATTRIBUTE_CUSTOM_4, ATTRIBUTE_CUSTOM_5, ATTRIBUTE_CUSTOM_6,
        /// ATTRIBUTE_CUSTOM_7, ATTRIBUTE_CUSTOM_8, ATTRIBUTE_CUSTOM_9, ATTRIBUTE_USER_DEFINED_MAPPING. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "attribute")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Attribute { get; set; }
        /// <summary>
        /// Match criteria. Enum options - IS_IN, IS_NOT_IN. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "match_operation")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchOperation { get; set; }
        /// <summary>
        /// The values to match. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> Values { get; set; }
    }
}
