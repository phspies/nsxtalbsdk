using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAuthenticationActionType
    {
        /// <summary>
        /// Authentication Action to be taken for a matched Rule. Enum options - SKIP_AUTHENTICATION, USE_DEFAULT_AUTHENTICATION.
        /// Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
