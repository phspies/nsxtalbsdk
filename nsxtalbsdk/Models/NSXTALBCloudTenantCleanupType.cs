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
    public class NSXTALBCloudTenantCleanupType 
    {
        /// <summary>
        /// id of CloudTenantCleanup.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Number of num_ports.
        /// </summary>
        [JsonProperty(PropertyName = "num_ports")]
        public int? NumPorts { get; set; }
        /// <summary>
        /// Number of num_se.
        /// </summary>
        [JsonProperty(PropertyName = "num_se")]
        public int? NumSe { get; set; }
        /// <summary>
        /// Number of num_secgrp.
        /// </summary>
        [JsonProperty(PropertyName = "num_secgrp")]
        public int? NumSecgrp { get; set; }
        /// <summary>
        /// Number of num_svrgrp.
        /// </summary>
        [JsonProperty(PropertyName = "num_svrgrp")]
        public int? NumSvrgrp { get; set; }
    }
}
