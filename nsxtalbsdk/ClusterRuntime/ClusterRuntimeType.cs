using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace nsxtalbsdk.Models
{
    public class ClusterRuntimeType
    {
        [JsonProperty("node_info")]
        public NodeInfo NodeInfo { get; set; }
        [JsonProperty("node_states")]
        public List<NodeState> NodeStates { get; set; }
        [JsonProperty("cluster_state")]
        public ClusterState ClusterState { get; set; }
        [JsonProperty("flavor")]
        public string Flavor { get; set; }
        [JsonProperty("service_states")]
        public List<ServiceState> ServiceStates { get; set; }
    }
    public class NodeInfo 
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
        [JsonProperty("ip")]
        public string Ip { get; set; }
        [JsonProperty("mgmt_ip")]
        public string MgmtIp { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("patch")]
        public string Patch { get; set; }
        [JsonProperty("vm_uuid")]
        public string VmUuid { get; set; }
        [JsonProperty("vm_mor")]
        public string VmMor { get; set; }
        [JsonProperty("cluster_uuid")]
        public string ClusterUuid { get; set; }
        [JsonProperty("fips_operational")]
        public string FipsOperational { get; set; }
    }
    public class NodeState
    {
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("mgmt_ip")]
        public string MgmtIp { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("up_since")]
        public string UpSince { get; set; }
    }
    public class ClusterState
    {
        [JsonProperty("up_since")]
        public string UpSince { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("progress")]
        public int Progress { get; set; }
    }
    public class Ip
    {
        [JsonProperty("addr")]
        public string Addr { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
    public class ClusterNode
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("ip")]
        public Ip Ip { get; set; }
    }
    public class ServiceState
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("roles")]
        public List<string> Roles { get; set; }
        [JsonProperty("cluster_nodes")]
        public List<ClusterNode> ClusterNodes { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("detailed_state")]
        public List<object> DetailedState { get; set; }
    }
}
