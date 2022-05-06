using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBL4RuleActionType
    {
        /// <summary>
        /// Indicates pool or pool-group selection on rule match. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "select_pool")]
        public NSXTALBL4RuleActionSelectPoolType SelectPool { get; set; }
    }
}
