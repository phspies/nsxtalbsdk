using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAutoScaleMesosSettingsType
    {
        /// <summary>
        /// Apply scale-out even when there are deployments inprogress.
        /// </summary>
        [JsonProperty(PropertyName = "force")]
        public bool? Force { get; set; }
    }
}
