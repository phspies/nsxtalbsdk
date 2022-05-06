using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsTxtRdataType
    {
        /// <summary>
        /// Text data associated with the FQDN. Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "text_str")]
        [System.ComponentModel.DataAnnotations.Required]
        public string TextStr { get; set; }
    }
}
