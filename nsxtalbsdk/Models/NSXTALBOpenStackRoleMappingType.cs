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
    public class NSXTALBOpenStackRoleMappingType 
    {
        public NSXTALBOpenStackRoleMappingType()
        {
        }
        /// <summary>
        /// Role name in Avi.
        /// </summary>
        [JsonProperty(PropertyName = "avi_role", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string AviRole { get; set; }
        /// <summary>
        /// Role name in OpenStack.
        /// </summary>
        [JsonProperty(PropertyName = "os_role", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string OsRole { get; set; }
    }
}
