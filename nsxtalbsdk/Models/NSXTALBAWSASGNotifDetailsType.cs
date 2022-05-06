using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAWSASGNotifDetailsType
    {
        /// <summary>
        /// asg_name of AWSASGNotifDetails.
        /// </summary>
        [JsonProperty(PropertyName = "asg_name")]
        public string? AsgName { get; set; }
        /// <summary>
        /// cc_id of AWSASGNotifDetails.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// error_string of AWSASGNotifDetails.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// event_type of AWSASGNotifDetails.
        /// </summary>
        [JsonProperty(PropertyName = "event_type")]
        public string? EventType { get; set; }
        /// <summary>
        /// instance_id of AWSASGNotifDetails.
        /// </summary>
        [JsonProperty(PropertyName = "instance_id")]
        public string? InstanceId { get; set; }
        /// <summary>
        /// Placeholder for description of property instance_ip_addr of obj type AWSASGNotifDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "instance_ip_addr")]
        public NSXTALBIpAddrType InstanceIpAddr { get; set; }
        /// <summary>
        /// UUID of the Pool. It is a reference to an object of type Pool. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        public string? PoolRef { get; set; }
        /// <summary>
        /// vpc_id of AWSASGNotifDetails.
        /// </summary>
        [JsonProperty(PropertyName = "vpc_id")]
        public string? VpcId { get; set; }
    }
}
