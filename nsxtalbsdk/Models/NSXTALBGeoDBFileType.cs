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
    public class NSXTALBGeoDBFileType 
    {
        /// <summary>
        /// If set to false, this file is ignored. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The file object that contains the geo data. Must be of type 'GeoDB'. It is a reference to an object of type FileObject.
        /// Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "file_ref", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string FileRef { get; set; }
        /// <summary>
        /// Priority of the file - larger number takes precedence. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Name of the file. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Source of the file data. Enum options - VENDOR_USER_DEFINED, VENDOR_AVI_DEFINED. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vendor", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vendor { get; set; }
    }
}
