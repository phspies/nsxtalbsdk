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
    public class NSXTALBSSLClientCertificateActionType 
    {
        /// <summary>
        /// Placeholder for description of property close_connection of obj type SSLClientCertificateAction field type str  type
        /// boolean
        /// </summary>
        [JsonProperty(PropertyName = "close_connection")]
        public bool? CloseConnection { get; set; }
        /// <summary>
        /// Placeholder for description of property headers of obj type SSLClientCertificateAction field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "headers")]
        public IList<NSXTALBSSLClientRequestHeaderType> Headers { get; set; }
    }
}
