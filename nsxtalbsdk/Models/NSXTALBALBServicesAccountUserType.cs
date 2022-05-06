using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBALBServicesAccountUserType
    {
        /// <summary>
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Email { get; set; }
        /// <summary>
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Phone { get; set; }
    }
}
