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
    public class NSXTALBVIControllerVnicInfoType 
    {
        public NSXTALBVIControllerVnicInfoType()
        {
        }
        /// <summary>
        /// portgroup of VIControllerVnicInfo.
        /// </summary>
        [JsonProperty(PropertyName = "portgroup", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Portgroup { get; set; }
        /// <summary>
        /// Placeholder for description of property vnic_ip of obj type VIControllerVnicInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vnic_ip")]
        public IList<NSXTALBVIGuestvNicIPAddrType> VnicIp { get; set; }
    }
}
