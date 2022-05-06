using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVIMgrInterestedEntityType
    {
        /// <summary>
        /// Unique object identifier of interested.
        /// </summary>
        [JsonProperty(PropertyName = "interested_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string InterestedUuid { get; set; }
    }
}
