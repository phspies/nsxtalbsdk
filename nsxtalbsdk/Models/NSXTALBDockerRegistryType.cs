using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDockerRegistryType
    {
        /// <summary>
        /// Openshift integrated registry config.
        /// </summary>
        [JsonProperty(PropertyName = "oshift_registry")]
        public NSXTALBOshiftDockerRegistryMetaDataType OshiftRegistry { get; set; }
        /// <summary>
        /// Password for docker registry. Authorized 'regular user' password if registry is Openshift integrated registry.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Set if docker registry is private. Avi controller will not attempt to push SE image to the registry, unless
        /// se_repository_push is set.
        /// </summary>
        [JsonProperty(PropertyName = "private")]
        public bool? Private { get; set; }
        /// <summary>
        /// Avi ServiceEngine repository name. For private registry, it's registry port/repository, for public registry, it's
        /// registry/repository, for openshift registry, it's registry port/namespace/repo.
        /// </summary>
        [JsonProperty(PropertyName = "registry")]
        public string? Registry { get; set; }
        /// <summary>
        /// Avi Controller will push ServiceEngine image to docker repository. Field deprecated in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_repository_push")]
        public bool? SeRepositoryPush { get; set; }
        /// <summary>
        /// Username for docker registry. Authorized 'regular user' if registry is Openshift integrated registry.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
    }
}
