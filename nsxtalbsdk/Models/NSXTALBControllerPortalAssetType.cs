using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBControllerPortalAssetType
    {
        /// <summary>
        /// Asset ID corresponding to this Controller Cluster, returned on a successful registration. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "asset_id")]
        public string? AssetId { get; set; }
    }
}
