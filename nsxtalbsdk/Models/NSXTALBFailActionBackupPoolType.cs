using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBFailActionBackupPoolType
    {
        /// <summary>
        /// Specifies the UUID of the Pool acting as backup pool. It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "backup_pool_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string BackupPoolRef { get; set; }
    }
}
