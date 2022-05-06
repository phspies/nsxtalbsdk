using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVinfraCntlrHostUnreachableListType
    {
        /// <summary>
        /// host_name of VinfraCntlrHostUnreachableList.
        /// </summary>
        [JsonProperty(PropertyName = "host_name")]
        public IList<string> HostName { get; set; }
        /// <summary>
        /// vcenter of VinfraCntlrHostUnreachableList.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vcenter { get; set; }
    }
}
