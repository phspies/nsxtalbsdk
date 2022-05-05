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
    public class NSXTALBDebugSeFaultType 
    {
        /// <summary>
        /// Set of faults to enable/disable. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "faults")]
        public IList<NSXTALBSeFaultType> Faults { get; set; }
        /// <summary>
        /// Fail SE malloc type at this frequency. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_malloc_fail_frequency")]
        public int? SeMallocFailFrequency { get; set; }
        /// <summary>
        /// Fail this SE malloc type. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_malloc_fail_type")]
        public int? SeMallocFailType { get; set; }
        /// <summary>
        /// Toggle assert on mbuf cluster sanity check fail. Field introduced in 17.2.13,18.1.3,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_mbuf_cl_sanity")]
        public bool? SeMbufClSanity { get; set; }
        /// <summary>
        /// Fail SE SHM malloc type at this frequency. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_shm_malloc_fail_frequency")]
        public int? SeShmMallocFailFrequency { get; set; }
        /// <summary>
        /// Fail this SE SHM malloc type. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_shm_malloc_fail_type")]
        public int? SeShmMallocFailType { get; set; }
        /// <summary>
        /// Fail SE WAF allocation at this frequency. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_waf_alloc_fail_frequency")]
        public int? SeWafAllocFailFrequency { get; set; }
        /// <summary>
        /// Fail SE WAF learning allocation at this frequency. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_waf_learning_alloc_fail_frequency")]
        public int? SeWafLearningAllocFailFrequency { get; set; }
    }
}
