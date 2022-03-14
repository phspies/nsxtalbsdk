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
    public class NSXTALBSEFaultInjectSeParamType 
    {
        /// <summary>
        /// Inject fault in specific core. Field introduced in 18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "core")]
        public int? Core { get; set; }
        /// <summary>
        /// Inject Fault on Objects. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "obj_names")]
        public IList<string> ObjNames { get; set; }
        /// <summary>
        /// Inject fault in random no of cores. Field introduced in 18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "random_core")]
        public bool? RandomCore { get; set; }
        /// <summary>
        /// Set se-agent fault type. Enum options - SE_AGENT_FAULT_DISABLED, SE_AGENT_PRE_PROCESS_FAULT,
        /// SE_AGENT_POST_PROCESS_FAULT, SE_AGENT_DP_RESPONSE_FAULT, SE_AGENT_RANDOM_PROCESS_FAULT. Field introduced in
        /// 18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_agent_fault")]
        public string? SeAgentFault { get; set; }
        /// <summary>
        /// Set se-dp fault type. Enum options - SE_DP_FAULT_DISABLED. Field introduced in 18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_fault")]
        public string? SeDpFault { get; set; }
    }
}
