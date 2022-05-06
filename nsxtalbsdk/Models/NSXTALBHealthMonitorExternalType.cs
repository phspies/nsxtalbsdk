using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHealthMonitorExternalType
    {
        /// <summary>
        /// Command script provided inline.
        /// </summary>
        [JsonProperty(PropertyName = "command_code")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CommandCode { get; set; }
        /// <summary>
        /// Optional arguments to feed into the script.
        /// </summary>
        [JsonProperty(PropertyName = "command_parameters")]
        public string? CommandParameters { get; set; }
        /// <summary>
        /// Path of external health monitor script.
        /// </summary>
        [JsonProperty(PropertyName = "command_path")]
        public string? CommandPath { get; set; }
        /// <summary>
        /// Environment variables to be fed into the script.
        /// </summary>
        [JsonProperty(PropertyName = "command_variables")]
        public string? CommandVariables { get; set; }
    }
}
