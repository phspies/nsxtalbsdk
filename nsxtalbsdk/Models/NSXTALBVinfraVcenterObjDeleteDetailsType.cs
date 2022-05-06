using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVinfraVcenterObjDeleteDetailsType
    {
        /// <summary>
        /// obj_name of VinfraVcenterObjDeleteDetails.
        /// </summary>
        [JsonProperty(PropertyName = "obj_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ObjName { get; set; }
        /// <summary>
        /// vcenter of VinfraVcenterObjDeleteDetails.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vcenter { get; set; }
    }
}
