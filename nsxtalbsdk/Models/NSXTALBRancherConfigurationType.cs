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
    public class NSXTALBRancherConfigurationType 
    {
        /// <summary>
        /// Access key.
        /// </summary>
        [JsonProperty(PropertyName = "access_key")]
        public string? AccessKey { get; set; }
        /// <summary>
        /// Sync frequency in seconds with frameworks.
        /// </summary>
        [JsonProperty(PropertyName = "app_sync_frequency")]
        public int? AppSyncFrequency { get; set; }
        /// <summary>
        /// Perform container port matching to create a HTTP Virtualservice instead of a TCP/UDP VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "container_port_match_http_service")]
        public bool? ContainerPortMatchHttpService { get; set; }
        /// <summary>
        /// Directory to mount to check for core dumps on Service Engines. This will be mapped read only to /var/crash on any new
        /// Service Engines. This is a disruptive change.
        /// </summary>
        [JsonProperty(PropertyName = "coredump_directory")]
        public string? CoredumpDirectory { get; set; }
        /// <summary>
        /// Disable auto service sync for back end services.
        /// </summary>
        [JsonProperty(PropertyName = "disable_auto_backend_service_sync")]
        public bool? DisableAutoBackendServiceSync { get; set; }
        /// <summary>
        /// Disable auto service sync for front end services.
        /// </summary>
        [JsonProperty(PropertyName = "disable_auto_frontend_service_sync")]
        public bool? DisableAutoFrontendServiceSync { get; set; }
        /// <summary>
        /// Disable SE creation.
        /// </summary>
        [JsonProperty(PropertyName = "disable_auto_se_creation")]
        public bool? DisableAutoSeCreation { get; set; }
        /// <summary>
        /// Docker registry for ServiceEngine image.
        /// </summary>
        [JsonProperty(PropertyName = "docker_registry_se")]
        public NSXTALBDockerRegistryType DockerRegistrySe { get; set; }
        /// <summary>
        /// Match against this prefix when placing east-west VSs on SEs .
        /// </summary>
        [JsonProperty(PropertyName = "east_west_placement_subnet")]
        public NSXTALBIpAddrPrefixType EastWestPlacementSubnet { get; set; }
        /// <summary>
        /// Enable Docker event subscription.
        /// </summary>
        [JsonProperty(PropertyName = "enable_event_subscription")]
        public bool? EnableEventSubscription { get; set; }
        /// <summary>
        /// For Front End proxies, use container port as service port.
        /// </summary>
        [JsonProperty(PropertyName = "feproxy_container_port_as_service")]
        public bool? FeproxyContainerPortAsService { get; set; }
        /// <summary>
        /// Enable proxy ARP from Host interface for Front End  proxies.
        /// </summary>
        [JsonProperty(PropertyName = "feproxy_vips_enable_proxy_arp")]
        public bool? FeproxyVipsEnableProxyArp { get; set; }
        /// <summary>
        /// Optional fleet remote endpoint if fleet is used for SE deployment.
        /// </summary>
        [JsonProperty(PropertyName = "fleet_endpoint")]
        public string? FleetEndpoint { get; set; }
        /// <summary>
        /// List of container ports that create a HTTP Virtualservice instead of a TCP/UDP VirtualService. Defaults to 80.
        /// </summary>
        [JsonProperty(PropertyName = "http_container_ports")]
        public int? HttpContainerPorts { get; set; }
        /// <summary>
        /// Nuage Overlay SDN Controller information.
        /// </summary>
        [JsonProperty(PropertyName = "nuage_controller")]
        public NSXTALBNuageSDNControllerType NuageController { get; set; }
        /// <summary>
        /// List of Rancher servers; In case of a load balanced Rancher multi cluster, use Virtual IP of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "rancher_servers")]
        public IList<string> RancherServers { get; set; }
        /// <summary>
        /// Use Fleet/SSH for SE deployment. Enum options - SE_CREATE_FLEET, SE_CREATE_SSH, SE_CREATE_POD.
        /// </summary>
        [JsonProperty(PropertyName = "se_deployment_method")]
        public string? SeDeploymentMethod { get; set; }
        /// <summary>
        /// Exclude hosts with attributes for SE creation.
        /// </summary>
        [JsonProperty(PropertyName = "se_exclude_attributes")]
        public IList<NSXTALBMesosAttributeType> SeExcludeAttributes { get; set; }
        /// <summary>
        /// Create SEs just on hosts with include attributes.
        /// </summary>
        [JsonProperty(PropertyName = "se_include_attributes")]
        public IList<NSXTALBMesosAttributeType> SeIncludeAttributes { get; set; }
        /// <summary>
        /// New SE spawn rate per minute.
        /// </summary>
        [JsonProperty(PropertyName = "se_spawn_rate")]
        public int? SeSpawnRate { get; set; }
        /// <summary>
        /// Host volume to be used as a disk for Avi SE, This is a disruptive change.
        /// </summary>
        [JsonProperty(PropertyName = "se_volume")]
        public string? SeVolume { get; set; }
        /// <summary>
        /// Secret key.
        /// </summary>
        [JsonProperty(PropertyName = "secret_key")]
        public string? SecretKey { get; set; }
        /// <summary>
        /// Make service ports accessible on all Host interfaces in addition to East-West VIP and/or bridge IP. Usually enabled AWS
        /// clusters to export East-West services on Host interface.
        /// </summary>
        [JsonProperty(PropertyName = "services_accessible_all_interfaces")]
        public bool? ServicesAccessibleAllInterfaces { get; set; }
        /// <summary>
        /// Parameters for SSH SE deployment. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssh_se_deployment")]
        public NSXTALBSSHSeDeploymentType SshSeDeployment { get; set; }
        /// <summary>
        /// Cloud connector user uuid for SSH to hosts. It is a reference to an object of type CloudConnectorUser. Field introduced
        /// in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssh_user_ref")]
        public string? SshUserRef { get; set; }
        /// <summary>
        /// Use container IP address port for pool instead of host IP address hostport. This mode is applicable if the container IP
        /// is reachable (not a private NATed IP) from other hosts in a routed environment for containers.
        /// </summary>
        [JsonProperty(PropertyName = "use_container_ip_port")]
        public bool? UseContainerIpPort { get; set; }
        /// <summary>
        /// If true, use controller generated SE docker image via fileservice, else use docker repository image as defined by
        /// docker_registry_se.
        /// </summary>
        [JsonProperty(PropertyName = "use_controller_image")]
        public bool? UseControllerImage { get; set; }
    }
}
