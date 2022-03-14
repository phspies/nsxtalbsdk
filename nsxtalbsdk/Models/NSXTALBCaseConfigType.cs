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
    public class NSXTALBCaseConfigType 
    {
        public NSXTALBCaseConfigType()
        {
        }
        /// <summary>
        /// Enable pro-active support case creation when a controller failure occurs. Field introduced in 21.1.1. Allowed in
        /// Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_auto_case_creation_on_controller_failure")]
        public bool? EnableAutoCaseCreationOnControllerFailure { get; set; }
        /// <summary>
        /// Enable pro-active support case creation when a service engine failure occurs. Field introduced in 21.1.1. Allowed in
        /// Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_auto_case_creation_on_se_failure")]
        public bool? EnableAutoCaseCreationOnSeFailure { get; set; }
        /// <summary>
        /// Enable cleanup of successfully attached files to support case. Field introduced in 21.1.1. Allowed in Basic(Allowed
        /// values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition. Special default for Basic edition
        /// is false, Essentials edition is false, Enterprise is True.
        /// </summary>
        [JsonProperty(PropertyName = "enable_cleanup_of_attached_files")]
        public bool? EnableCleanupOfAttachedFiles { get; set; }
    }
}
