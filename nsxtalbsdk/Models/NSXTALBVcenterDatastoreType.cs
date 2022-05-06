using Newtonsoft.Json;
using System.Linq;
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
