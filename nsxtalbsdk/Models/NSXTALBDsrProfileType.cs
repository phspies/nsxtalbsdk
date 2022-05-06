using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDsrProfileType
    {
        /// <summary>
        /// Encapsulation type to use when DSR is L3. Enum options - ENCAP_IPINIP, ENCAP_GRE. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "dsr_encap_type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DsrEncapType { get; set; }
        /// <summary>
        /// DSR type L2/L3. Enum options - DSR_TYPE_L2, DSR_TYPE_L3. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "dsr_type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DsrType { get; set; }
    }
}
