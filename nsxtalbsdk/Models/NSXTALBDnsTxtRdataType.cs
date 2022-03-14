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
    public class NSXTALBDnsTxtRdataType 
    {
        /// <summary>
        /// Text data associated with the FQDN. Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "text_str", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string TextStr { get; set; }
    }
}
