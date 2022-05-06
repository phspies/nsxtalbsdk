using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBJWTValidationParamsType
    {
        /// <summary>
        /// Audience parameter used for validation using JWT token. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "audience")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Audience { get; set; }
    }
}
