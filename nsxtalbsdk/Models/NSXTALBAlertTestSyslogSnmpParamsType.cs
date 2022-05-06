using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAlertTestSyslogSnmpParamsType
    {
        /// <summary>
        /// The contents of the Syslog message/SNMP Trap contents.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Text { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
