using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBContainerCloudBatchSetupType
    {
        /// <summary>
        /// Placeholder for description of property ccs of obj type ContainerCloudBatchSetup field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ccs")]
        public IList<NSXTALBContainerCloudSetupType> Ccs { get; set; }
    }
}
