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
    public class NSXTALBControllerPortalAssetType 
    {
        public NSXTALBControllerPortalAssetType()
        {
        }
        /// <summary>
        /// Asset ID corresponding to this Controller Cluster, returned on a successful registration. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "asset_id")]
        public string? AssetId { get; set; }
    }
}
