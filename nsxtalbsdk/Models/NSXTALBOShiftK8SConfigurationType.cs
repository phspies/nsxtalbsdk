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
    public class NSXTALBOShiftK8SConfigurationType 
    {
        /// <summary>
        /// Sync frequency in seconds with frameworks.
        /// </summary>
        [JsonProperty(PropertyName = "app_sync_frequency")]
        public int? AppSyncFrequency { get; set; }
        /// <summary>
        /// Auto assign FQDN to a virtual service if a valid FQDN is not configured. Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "auto_assign_fqdn")]
        public bool? AutoAssignFqdn { get; set; }
        /// <summary>
        /// Avi Linux bridge subnet on OpenShift/K8s nodes.
        /// </summary>
        [JsonProperty(PropertyName = "avi_bridge_subnet")]
        public NSXTALBIpAddrPrefixType AviBridgeSubnet { get; set; }
        /// <summary>
        /// UUID of the UCP CA TLS cert and key. It is a reference to an object of type SSLKeyAndCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "ca_tls_key_and_certificate_ref")]
        public string? CaTlsKeyAndCertificateRef { get; set; }
        /// <summary>
        /// UUID of the client TLS cert and key instead of service account token. One of client certificate or token is required. It
        /// is a reference to an object of type SSLKeyAndCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "client_tls_key_and_certificate_ref")]
        public string? ClientTlsKeyAndCertificateRef { get; set; }
        /// <summary>
        /// Openshift/K8S Cluster ID used to uniquely map same named namespaces as tenants in Avi. In order to use more than one
        /// OpenShift/K8S cloud on this controller, cluster_tag has to be unique across these clouds. Changing cluster_tag is
        /// disruptive as all virtual services in the cloud will be recreated. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_tag")]
        public string? ClusterTag { get; set; }
        /// <summary>
        /// Perform container port matching to create a HTTP Virtualservice instead of a TCP/UDP VirtualService. By default, ports
        /// 80, 8080, 443, 8443 are considered HTTP.
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
        /// If there is no explicit east_west_placement field in virtualservice configuration, treat service as a East-West service;
        /// default services such a OpenShift API server do not have virtualservice configuration.
        /// </summary>
        [JsonProperty(PropertyName = "default_service_as_east_west_service")]
        public bool? DefaultServiceAsEastWestService { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 17.1.9. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "default_shared_virtualservice")]
        public NSXTALBOshiftSharedVirtualServiceType DefaultSharedVirtualservice { get; set; }
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
        /// Disable auto sync for GSLB services. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "disable_auto_gs_sync")]
        public bool? DisableAutoGsSync { get; set; }
        /// <summary>
        /// Disable SE creation.
        /// </summary>
        [JsonProperty(PropertyName = "disable_auto_se_creation")]
        public bool? DisableAutoSeCreation { get; set; }
        /// <summary>
        /// Host Docker server UNIX socket endpoint. Field introduced in 17.2.14, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "docker_endpoint")]
        public string? DockerEndpoint { get; set; }
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
        /// Enable Kubernetes event subscription.
        /// </summary>
        [JsonProperty(PropertyName = "enable_event_subscription")]
        public bool? EnableEventSubscription { get; set; }
        /// <summary>
        /// Knob to turn on adding of HTTP drop rules for host and path combinations in incoming request header, specified as part
        /// of Ingress/Route spec. The default state is to enable this behavior. Note  Toggling this knob only affects any new
        /// routes/ingresses, existing routes/ingresses present in Avi will continue to function as-is. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "enable_route_ingress_hardening")]
        public bool? EnableRouteIngressHardening { get; set; }
        /// <summary>
        /// Enable proxy ARP from Host interface for Front End  proxies.
        /// </summary>
        [JsonProperty(PropertyName = "feproxy_vips_enable_proxy_arp")]
        public bool? FeproxyVipsEnableProxyArp { get; set; }
        /// <summary>
        /// Optional fleet remote endpoint if fleet is used for SE deployment. Field deprecated in 17.2.13,18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "fleet_endpoint")]
        public string? FleetEndpoint { get; set; }
        /// <summary>
        /// List of container ports that create a HTTP Virtualservice instead of a TCP/UDP VirtualService. Defaults to 80, 8080, 443
        /// and 8443.
        /// </summary>
        [JsonProperty(PropertyName = "http_container_ports")]
        public int? HttpContainerPorts { get; set; }
        /// <summary>
        /// Do not sync applications only for ingress that have these exclude attributes configured. Field introduced in 17.2.15,
        /// 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "ing_exclude_attributes")]
        public IList<NSXTALBIngAttributeType> IngExcludeAttributes { get; set; }
        /// <summary>
        /// Sync applications only for ingress objects that have these include attributes configured. Default values are populated
        /// for this field if not provided. The default value are  'attribute'  'kubernetes.io/ingress.class', 'value' 'avi'. Field
        /// introduced in 17.2.15, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "ing_include_attributes")]
        public IList<NSXTALBIngAttributeType> IngIncludeAttributes { get; set; }
        /// <summary>
        /// Perform Layer4 (TCP/UDP) health monitoring even for Layer7 (HTTP) Pools.
        /// </summary>
        [JsonProperty(PropertyName = "l4_health_monitoring")]
        public bool? L4HealthMonitoring { get; set; }
        /// <summary>
        /// List of OpenShift/Kubernetes master nodes; In case of a load balanced OpenShift/K8S cluster, use Virtual IP of the
        /// cluster. Each node is of the form node 8443 or http //node 8080. If scheme is not provided, https is assumed.
        /// </summary>
        [JsonProperty(PropertyName = "master_nodes")]
        public IList<string> MasterNodes { get; set; }
        /// <summary>
        /// OpenShift/K8S Node label to be used as OpenShift/K8S Node's availability zone in a dual availability zone deployment.
        /// ServiceEngines belonging to the availability zone will be rebooted during a manual DR failover.
        /// </summary>
        [JsonProperty(PropertyName = "node_availability_zone_label")]
        public string? NodeAvailabilityZoneLabel { get; set; }
        /// <summary>
        /// Syncing of applications is disabled only for namespaces/projects that have these exclude attributes configured. If there
        /// are apps synced already for these namespaces, they will be removed from Avi. Field introduced in 17.1.9,17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "ns_exclude_attributes")]
        public IList<NSXTALBMesosAttributeType> NsExcludeAttributes { get; set; }
        /// <summary>
        /// Sync applications only for namespaces/projects that have these include attributes configured. Field introduced in
        /// 17.1.9,17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "ns_include_attributes")]
        public IList<NSXTALBMesosAttributeType> NsIncludeAttributes { get; set; }
        /// <summary>
        /// Nuage Overlay SDN Controller information. Field deprecated in 17.2.13,18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "nuage_controller")]
        public NSXTALBNuageSDNControllerType NuageController { get; set; }
        /// <summary>
        /// Enables sharding of Routes and Ingresses to this number (if non zero) of virtual services in the admin tenant per
        /// SEGroup. Sharding is done by hashing on the namespace of the Ingress/Route object. This knob is valid only if
        /// shared_virtualservice_namespace flag is set. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "num_shards")]
        public int? NumShards { get; set; }
        /// <summary>
        /// Override Service Ports with well known ports (80/443) for http/https Route/Ingress VirtualServices. Field introduced in
        /// 17.2.12,18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "override_service_ports")]
        public bool? OverrideServicePorts { get; set; }
        /// <summary>
        /// Persistent Volume Claim name to be used for persistent storage for Avi service engines. This could be used in scenarios
        /// where host based volumes are ephemeral. Refer https
        /// //kubernetes.io/docs/concepts/storage/persistent-volumes/#persistentvolumeclaims for more details on the usage of this
        /// field. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "persistent_volume_claim")]
        public string? PersistentVolumeClaim { get; set; }
        /// <summary>
        /// Routes support adding routes to a particular namespace routing table in Openshift/K8s cluster. Each route is a
        /// combination of subnet and nexthop ip address or nexthop interface name, and a enum type is used to distinguish an entry
        /// in the host (default behaviour) or in the container/pod or in other namespace. This knob should be enabled in the
        /// following cases  1. Forwarding the network packets to the same network interface from where it came from in the
        /// OpenShift/K8s node. 2. OpenShift/K8s Node connected to the Internet via multiple network interfaces on different
        /// networks/ISPs.3. Handling North-South traffic originating from with in the node when the default gateway for outgoing
        /// traffic of vs is configured.4. Handling the container/pod traffic by adding the routes in the container/pod. Field
        /// introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "routes")]
        public IList<NSXTALBRouteInfoType> Routes { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 17.1.9. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "routes_share_virtualservice")]
        public bool? RoutesShareVirtualservice { get; set; }
        /// <summary>
        /// Cluster uses overlay based SDN. Enable this flag if cluster uses a overlay based SDN for OpenShift, Flannel, Weave,
        /// Nuage. Disable for routed mode.
        /// </summary>
        [JsonProperty(PropertyName = "sdn_overlay")]
        public bool? SdnOverlay { get; set; }
        /// <summary>
        /// Use SSH/Pod for SE deployment. Enum options - SE_CREATE_FLEET, SE_CREATE_SSH, SE_CREATE_POD.
        /// </summary>
        [JsonProperty(PropertyName = "se_deployment_method")]
        public string? SeDeploymentMethod { get; set; }
        /// <summary>
        /// Exclude hosts with attributes for SE creation.
        /// </summary>
        [JsonProperty(PropertyName = "se_exclude_attributes")]
        public IList<NSXTALBMesosAttributeType> SeExcludeAttributes { get; set; }
        /// <summary>
        /// OpenShift/K8S secret name to be used for private docker repos when deploying SE as a Pod. Reference Link  https
        /// //kubernetes.io/docs/tasks/configure-pod-container/pull-image-private-registry/. Field introduced in
        /// 17.2.13,18.1.3,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_image_pull_secret")]
        public string? SeImagePullSecret { get; set; }
        /// <summary>
        /// Create SEs just on hosts with include attributes.
        /// </summary>
        [JsonProperty(PropertyName = "se_include_attributes")]
        public IList<NSXTALBMesosAttributeType> SeIncludeAttributes { get; set; }
        /// <summary>
        /// Kubernetes namespace to be used for deploying Avi service engines. This namespace is used to create daemonsets, service
        /// accounts, etc. for Avi only use. Setting this value is a disruptive operation and assumes the namespace exists in
        /// kubernetes. 'default' namespace is picked if this field is unset. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_namespace")]
        public string? SeNamespace { get; set; }
        /// <summary>
        /// Match SE Pod tolerations against taints of OpenShift/K8S nodes https
        /// //kubernetes.io/docs/concepts/configuration/taint-and-toleration/. Field introduced in 17.2.14, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_pod_tolerations")]
        public IList<NSXTALBPodTolerationType> SePodTolerations { get; set; }
        /// <summary>
        /// Priority class for AVI SEs when running as pods. User is expected to have the priority class (with this name) created in
        /// Kubernetes, beforehand. If the priority class doesn't exist while assigning this field, the SE pods may not start. If
        /// empty no priority class will be used for deploying SE pods (default behaviour). Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_priority_class")]
        public string? SePriorityClass { get; set; }
        /// <summary>
        /// Restart ServiceEngines by batch on ServiceEngineGroup updates (cpu, memory..etc). Field introduced in 17.2.15, 18.1.5,
        /// 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_restart_batch_size")]
        public int? SeRestartBatchSize { get; set; }
        /// <summary>
        /// Restart ServiceEngines forcely if VirtualServices failed to migrate to another SE. Field introduced in 17.2.15, 18.1.5,
        /// 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_restart_force")]
        public bool? SeRestartForce { get; set; }
        /// <summary>
        /// New SE spawn rate per minute. Field deprecated in 17.2.13,18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_spawn_rate")]
        public int? SeSpawnRate { get; set; }
        /// <summary>
        /// Host volume to be used as a disk for Avi SE, This is a disruptive change.
        /// </summary>
        [JsonProperty(PropertyName = "se_volume")]
        public string? SeVolume { get; set; }
        /// <summary>
        /// Allow Avi Vantage to create SecurityContextConstraints and ServiceAccounts which allow Egress Pods to run in privileged
        /// mode in an Openshift environment. Enabling this would exclude egress services from 'disable_auto_backend_service_sync'
        /// (if set) behaviour. Note  Access credentials must have cluster-admin role privileges. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "secure_egress_mode")]
        public bool? SecureEgressMode { get; set; }
        /// <summary>
        /// Authorization token for service account instead of client certificate. One of client certificate or token is required.
        /// </summary>
        [JsonProperty(PropertyName = "service_account_token")]
        public string? ServiceAccountToken { get; set; }
        /// <summary>
        /// Perform service port matching to create a HTTP Virtualservice instead of a TCP/UDP VirtualService. Field deprecated in
        /// 17.2.11,18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "service_port_match_http_service")]
        public bool? ServicePortMatchHttpService { get; set; }
        /// <summary>
        /// Prefix to be used for Shard VS name when num_shards knob is non zero. Format for Shard VS name will be
        /// <shard_prefix>-<idx>-CloudName-SEGroupName. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "shard_prefix")]
        public string? ShardPrefix { get; set; }
        /// <summary>
        /// Projects/Namespaces use a shared virtualservice for http/https Routes and Ingress objects unless overriden by the
        /// avi_virtualservice  dedicated|shared annotation. Field introduced in 17.1.9,17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "shared_virtualservice_namespace")]
        public bool? SharedVirtualserviceNamespace { get; set; }
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
        /// Allow the not_ready_addresses in the kubernetes endpoint object to be added as servers in the AVI pool object. Field
        /// introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "sync_not_ready_addresses")]
        public bool? SyncNotReadyAddresses { get; set; }
        /// <summary>
        /// If true, use controller generated SE docker image via fileservice, else use docker repository image as defined by
        /// docker_registry_se.
        /// </summary>
        [JsonProperty(PropertyName = "use_controller_image")]
        public bool? UseControllerImage { get; set; }
        /// <summary>
        /// Use OpenShift/Kubernetes resource definition and annotations as single-source-of-truth. Any changes made in Avi
        /// Controller via UI or CLI will be overridden by values provided in annotations. Field introduced in 17.2.13, 18.1.4,
        /// 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "use_resource_definition_as_ssot")]
        public bool? UseResourceDefinitionAsSsot { get; set; }
        /// <summary>
        /// Enable VirtualService placement on Service Engines on nodes with scheduling disabled. When false, Service Engines are
        /// disabled on nodes where scheduling is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "use_scheduling_disabled_nodes")]
        public bool? UseSchedulingDisabledNodes { get; set; }
        /// <summary>
        /// Use Cluster IP of service as VIP for East-West services; This option requires that kube proxy is disabled on all nodes.
        /// </summary>
        [JsonProperty(PropertyName = "use_service_cluster_ip_as_ew_vip")]
        public bool? UseServiceClusterIpAsEwVip { get; set; }
        /// <summary>
        /// VirtualService default gateway if multiple nics are present in the host. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "vip_default_gateway")]
        public NSXTALBIpAddrType VipDefaultGateway { get; set; }
    }
}
