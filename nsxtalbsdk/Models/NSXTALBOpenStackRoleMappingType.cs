using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBOpenStackRoleMappingType
    {
        /// <summary>
        /// Role name in Avi.
        /// </summary>
        [JsonProperty(PropertyName = "avi_role")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AviRole { get; set; }
        /// <summary>
        /// Role name in OpenStack.
        /// </summary>
        [JsonProperty(PropertyName = "os_role")]
        [System.ComponentModel.DataAnnotations.Required]
        public string OsRole { get; set; }
    }
}
