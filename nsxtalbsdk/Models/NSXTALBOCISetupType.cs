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
    public class NSXTALBOCISetupType 
    {
        /// <summary>
        /// cc_id of OCISetup.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// compartment_id of OCISetup.
        /// </summary>
        [JsonProperty(PropertyName = "compartment_id")]
        public string? CompartmentId { get; set; }
        /// <summary>
        /// reason of OCISetup.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// status of OCISetup.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// tenancy of OCISetup.
        /// </summary>
        [JsonProperty(PropertyName = "tenancy")]
        public string? Tenancy { get; set; }
        /// <summary>
        /// vcn_id of OCISetup.
        /// </summary>
        [JsonProperty(PropertyName = "vcn_id")]
        public string? VcnId { get; set; }
    }
}
