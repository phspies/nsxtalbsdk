using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBNuageSDNControllerType
    {
        /// <summary>
        /// nuage_organization of NuageSDNController.
        /// </summary>
        [JsonProperty(PropertyName = "nuage_organization")]
        public string? NuageOrganization { get; set; }
        /// <summary>
        /// nuage_password of NuageSDNController.
        /// </summary>
        [JsonProperty(PropertyName = "nuage_password")]
        public string? NuagePassword { get; set; }
        /// <summary>
        /// Number of nuage_port.
        /// </summary>
        [JsonProperty(PropertyName = "nuage_port")]
        public int? NuagePort { get; set; }
        /// <summary>
        /// nuage_username of NuageSDNController.
        /// </summary>
        [JsonProperty(PropertyName = "nuage_username")]
        public string? NuageUsername { get; set; }
        /// <summary>
        /// Nuage VSD host name or IP address.
        /// </summary>
        [JsonProperty(PropertyName = "nuage_vsd_host")]
        public string? NuageVsdHost { get; set; }
        /// <summary>
        /// Domain to be used for SE creation.
        /// </summary>
        [JsonProperty(PropertyName = "se_domain")]
        public string? SeDomain { get; set; }
        /// <summary>
        /// Enterprise to be used for SE creation.
        /// </summary>
        [JsonProperty(PropertyName = "se_enterprise")]
        public string? SeEnterprise { get; set; }
        /// <summary>
        /// Network to be used for SE creation.
        /// </summary>
        [JsonProperty(PropertyName = "se_network")]
        public string? SeNetwork { get; set; }
        /// <summary>
        /// Policy Group to be used for SE creation.
        /// </summary>
        [JsonProperty(PropertyName = "se_policy_group")]
        public string? SePolicyGroup { get; set; }
        /// <summary>
        /// User to be used for SE creation.
        /// </summary>
        [JsonProperty(PropertyName = "se_user")]
        public string? SeUser { get; set; }
        /// <summary>
        /// Zone to be used for SE creation.
        /// </summary>
        [JsonProperty(PropertyName = "se_zone")]
        public string? SeZone { get; set; }
    }
}
