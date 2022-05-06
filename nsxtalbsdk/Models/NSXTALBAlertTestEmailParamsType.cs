using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAlertTestEmailParamsType
    {
        /// <summary>
        /// The Subject line of the originating email from  Avi Controller.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Subject { get; set; }
        /// <summary>
        /// The email context.
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
