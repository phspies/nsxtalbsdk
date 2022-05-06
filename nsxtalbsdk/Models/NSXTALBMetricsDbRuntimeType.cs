using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBMetricsDbRuntimeType
    {
        /// <summary>
        /// Number of db_num_client_queries.
        /// </summary>
        [JsonProperty(PropertyName = "db_num_client_queries")]
        public int? DbNumClientQueries { get; set; }
        /// <summary>
        /// Number of db_num_client_resp.
        /// </summary>
        [JsonProperty(PropertyName = "db_num_client_resp")]
        public int? DbNumClientResp { get; set; }
        /// <summary>
        /// Number of db_num_db_queries.
        /// </summary>
        [JsonProperty(PropertyName = "db_num_db_queries")]
        public int? DbNumDbQueries { get; set; }
        /// <summary>
        /// Number of db_num_db_resp.
        /// </summary>
        [JsonProperty(PropertyName = "db_num_db_resp")]
        public int? DbNumDbResp { get; set; }
        /// <summary>
        /// Number of db_num_oom.
        /// </summary>
        [JsonProperty(PropertyName = "db_num_oom")]
        public int? DbNumOom { get; set; }
        /// <summary>
        /// Number of db_queue_size.
        /// </summary>
        [JsonProperty(PropertyName = "db_queue_size")]
        public int? DbQueueSize { get; set; }
        /// <summary>
        /// Number of db_rum_queries.
        /// </summary>
        [JsonProperty(PropertyName = "db_rum_queries")]
        public int? DbRumQueries { get; set; }
        /// <summary>
        /// Number of db_rum_rows.
        /// </summary>
        [JsonProperty(PropertyName = "db_rum_rows")]
        public int? DbRumRows { get; set; }
    }
}
