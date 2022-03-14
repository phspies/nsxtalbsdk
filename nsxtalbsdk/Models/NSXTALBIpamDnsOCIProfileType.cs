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
    public class NSXTALBIpamDnsOCIProfileType 
    {
        public NSXTALBIpamDnsOCIProfileType()
        {
        }
        /// <summary>
        /// Credentials to access oracle cloud. It is a reference to an object of type CloudConnectorUser. Field introduced in
        /// 18.2.1,18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_credentials_ref")]
        public string? CloudCredentialsRef { get; set; }
        /// <summary>
        /// Region in which Oracle cloud resource resides. Field introduced in 18.2.1,18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string? Region { get; set; }
        /// <summary>
        /// Oracle Cloud Id for tenant aka root compartment. Field introduced in 18.2.1,18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "tenancy")]
        public string? Tenancy { get; set; }
        /// <summary>
        /// Oracle cloud compartment id in which VCN resides. Field introduced in 18.2.1,18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vcn_compartment_id")]
        public string? VcnCompartmentId { get; set; }
        /// <summary>
        /// Virtual Cloud network id where virtual ip will belong. Field introduced in 18.2.1,18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vcn_id")]
        public string? VcnId { get; set; }
    }
}
