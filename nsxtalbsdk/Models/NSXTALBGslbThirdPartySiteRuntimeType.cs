using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGslbThirdPartySiteRuntimeType
    {
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "site_info")]
        public NSXTALBGslbSiteRuntimeInfoType SiteInfo { get; set; }
    }
}
