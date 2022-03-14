using nsxtalbsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [JsonProperty(PropertyName = "vcenter", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vcenter { get; set; }
    }
}
