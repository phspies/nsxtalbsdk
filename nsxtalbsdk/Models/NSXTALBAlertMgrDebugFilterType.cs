using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAlertMgrDebugFilterType
    {
        /// <summary>
        /// filter debugs for entity uuid.
        /// </summary>
        [JsonProperty(PropertyName = "alert_objid")]
        public string? AlertObjid { get; set; }
        /// <summary>
        /// filter debugs for an alert id.
        /// </summary>
        [JsonProperty(PropertyName = "alert_uuid")]
        public string? AlertUuid { get; set; }
        /// <summary>
        /// filter debugs for an alert config.
        /// </summary>
        [JsonProperty(PropertyName = "cfg_uuid")]
        public string? CfgUuid { get; set; }
    }
}
