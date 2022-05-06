using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsCnameRdataType
    {
        /// <summary>
        /// Canonical name.
        /// </summary>
        [JsonProperty(PropertyName = "cname")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Cname { get; set; }
    }
}
