using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBBotManagementLogType
    {
        /// <summary>
        /// The final classification of the bot management module. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "classification")]
        public NSXTALBBotClassificationType Classification { get; set; }
        /// <summary>
        /// The evaluation results of the various bot module components. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTALBBotEvaluationResultType> Results { get; set; }
    }
}
