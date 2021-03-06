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
    public class NSXTALBVcenterDatastoreType 
    {
        /// <summary>
        /// datastore_name of VcenterDatastore.
        /// </summary>
        [JsonProperty(PropertyName = "datastore_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DatastoreName { get; set; }
    }
}
