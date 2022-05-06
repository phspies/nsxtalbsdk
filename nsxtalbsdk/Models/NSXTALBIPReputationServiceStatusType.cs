using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBIPReputationServiceStatusType
    {
        /// <summary>
        /// If the last attempted update failed, this is a more detailed error message. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
        /// <summary>
        /// The time when the IP reputation service last successfull attemped to update this object. This is the case when either
        /// this file references in this object got updated or when the IP reputation service knows positively that there are no
        /// newer versions for these files. It will be not update, if an error occurs during an update attempt. In this case, the
        /// errror will be set. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "last_successful_update_check")]
        public NSXTALBTimeStampType LastSuccessfulUpdateCheck { get; set; }
    }
}
