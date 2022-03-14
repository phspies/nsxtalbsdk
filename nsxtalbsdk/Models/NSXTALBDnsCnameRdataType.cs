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
    public class NSXTALBDnsCnameRdataType 
    {
        public NSXTALBDnsCnameRdataType()
        {
        }
        /// <summary>
        /// Canonical name.
        /// </summary>
        [JsonProperty(PropertyName = "cname", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Cname { get; set; }
    }
}
