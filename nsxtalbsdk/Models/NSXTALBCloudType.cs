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
    public class NSXTALBCloudType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_configuration")]
        public NSXTALBAPICConfigurationType ApicConfiguration { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "apic_mode")]
        public bool? ApicMode { get; set; }
        /// <summary>
        /// CloudConnector polling interval in seconds for external autoscale groups, minimum 60 seconds. Allowed values are
        /// 60-3600. Field introduced in 18.2.2. Unit is SECONDS. Allowed in Basic(Allowed values- 60) edition, Essentials(Allowed
        /// values- 60) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "autoscale_polling_interval")]
        public int? AutoscalePollingInterval { get; set; }
        /// <summary>
        /// Placeholder for description of property aws_configuration of obj type Cloud field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "aws_configuration")]
        public NSXTALBAwsConfigurationType AwsConfiguration { get; set; }
        /// <summary>
        /// Field introduced in 17.2.1. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "azure_configuration")]
        public NSXTALBAzureConfigurationType AzureConfiguration { get; set; }
        /// <summary>
        /// Placeholder for description of property cloudstack_configuration of obj type Cloud field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cloudstack_configuration")]
        public NSXTALBCloudStackConfigurationType CloudstackConfiguration { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Custom tags for all Avi created resources in the cloud infrastructure. Field introduced in 17.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "custom_tags")]
        public IList<NSXTALBCustomTagType> CustomTags { get; set; }
        /// <summary>
        /// Select the IP address management scheme.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_enabled")]
        public bool? DhcpEnabled { get; set; }
        /// <summary>
        /// DNS Profile for the cloud. It is a reference to an object of type IpamDnsProviderProfile.
        /// </summary>
        [JsonProperty(PropertyName = "dns_provider_ref")]
        public string? DnsProviderRef { get; set; }
        /// <summary>
        /// By default, pool member FQDNs are resolved on the Controller. When this is set, pool member FQDNs are instead resolved
        /// on Service Engines in this cloud. This is useful in scenarios where pool member FQDNs can only be resolved from Service
        /// Engines and not from the Controller. Field introduced in 18.2.6. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "dns_resolution_on_se")]
        public bool? DnsResolutionOnSe { get; set; }
        /// <summary>
        /// DNS resolver for the cloud. Field introduced in 20.1.5. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "dns_resolvers")]
        public IList<NSXTALBDnsResolverType> DnsResolvers { get; set; }
        /// <summary>
        /// Placeholder for description of property docker_configuration of obj type Cloud field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "docker_configuration")]
        public NSXTALBDockerConfigurationType DockerConfiguration { get; set; }
        /// <summary>
        /// DNS Profile for East-West services. It is a reference to an object of type IpamDnsProviderProfile.
        /// </summary>
        [JsonProperty(PropertyName = "east_west_dns_provider_ref")]
        public string? EastWestDnsProviderRef { get; set; }
        /// <summary>
        /// Ipam Profile for East-West services. Warning - Please use virtual subnets in this IPAM profile that do not conflict with
        /// the underlay networks or any overlay networks in the cluster. For example in AWS and GCP, 169.254.0.0/16 is used for
        /// storing instance metadata. Hence, it should not be used in this profile. It is a reference to an object of type
        /// IpamDnsProviderProfile.
        /// </summary>
        [JsonProperty(PropertyName = "east_west_ipam_provider_ref")]
        public string? EastWestIpamProviderRef { get; set; }
        /// <summary>
        /// Enable VIP on all data interfaces for the Cloud. Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_vip_on_all_interfaces")]
        public bool? EnableVipOnAllInterfaces { get; set; }
        /// <summary>
        /// Use static routes for VIP side network resolution during VirtualService placement.
        /// </summary>
        [JsonProperty(PropertyName = "enable_vip_static_routes")]
        public bool? EnableVipStaticRoutes { get; set; }
        /// <summary>
        /// Google Cloud Platform Configuration. Field introduced in 18.2.1. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "gcp_configuration")]
        public NSXTALBGCPConfigurationType GcpConfiguration { get; set; }
        /// <summary>
        /// Enable IPv6 auto configuration. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip6_autocfg_enabled")]
        public bool? Ip6AutocfgEnabled { get; set; }
        /// <summary>
        /// Ipam Profile for the cloud. It is a reference to an object of type IpamDnsProviderProfile.
        /// </summary>
        [JsonProperty(PropertyName = "ipam_provider_ref")]
        public string? IpamProviderRef { get; set; }
        /// <summary>
        /// Specifies the default license tier which would be used by new SE Groups. This field by default inherits the value from
        /// system configuration. Enum options - ENTERPRISE_16, ENTERPRISE, ENTERPRISE_18, BASIC, ESSENTIALS,
        /// ENTERPRISE_WITH_CLOUD_SERVICES. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "license_tier")]
        public string? LicenseTier { get; set; }
        /// <summary>
        /// If no license type is specified then default license enforcement for the cloud type is chosen. The default mappings are
        /// Container Cloud is Max Ses, OpenStack and VMware is cores and linux it is Sockets. Enum options - LIC_BACKEND_SERVERS,
        /// LIC_SOCKETS, LIC_CORES, LIC_HOSTS, LIC_SE_BANDWIDTH, LIC_METERED_SE_BANDWIDTH.
        /// </summary>
        [JsonProperty(PropertyName = "license_type")]
        public string? LicenseType { get; set; }
        /// <summary>
        /// Placeholder for description of property linuxserver_configuration of obj type Cloud field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "linuxserver_configuration")]
        public NSXTALBLinuxServerConfigurationType LinuxserverConfiguration { get; set; }
        /// <summary>
        /// Cloud is in maintenance mode. Field introduced in 20.1.7,21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_mode")]
        public bool? MaintenanceMode { get; set; }
        /// <summary>
        /// Field deprecated in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "mesos_configuration")]
        public NSXTALBMesosConfigurationType MesosConfiguration { get; set; }
        /// <summary>
        /// MTU setting for the cloud. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "mtu")]
        public int? Mtu { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Configuration parameters for NSX Manager. Field deprecated in 21.1.1. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_configuration")]
        public NSXTALBNsxConfigurationType NsxConfiguration { get; set; }
        /// <summary>
        /// NSX-T Cloud Platform Configuration. Field introduced in 20.1.1. Allowed in Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_configuration")]
        public NSXTALBNsxtConfigurationType NsxtConfiguration { get; set; }
        /// <summary>
        /// Default prefix for all automatically created objects in this cloud. This prefix can be overridden by the SE-Group
        /// template.
        /// </summary>
        [JsonProperty(PropertyName = "obj_name_prefix")]
        public string? ObjNamePrefix { get; set; }
        /// <summary>
        /// Placeholder for description of property openstack_configuration of obj type Cloud field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "openstack_configuration")]
        public NSXTALBOpenStackConfigurationType OpenstackConfiguration { get; set; }
        /// <summary>
        /// Field deprecated in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "oshiftk8s_configuration")]
        public NSXTALBOShiftK8SConfigurationType Oshiftk8sConfiguration { get; set; }
        /// <summary>
        /// Prefer static routes over interface routes during VirtualService placement.
        /// </summary>
        [JsonProperty(PropertyName = "prefer_static_routes")]
        public bool? PreferStaticRoutes { get; set; }
        /// <summary>
        /// Placeholder for description of property proxy_configuration of obj type Cloud field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "proxy_configuration")]
        public NSXTALBProxyConfigurationType ProxyConfiguration { get; set; }
        /// <summary>
        /// Placeholder for description of property rancher_configuration of obj type Cloud field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "rancher_configuration")]
        public NSXTALBRancherConfigurationType RancherConfiguration { get; set; }
        /// <summary>
        /// The Service Engine Group to use as template. It is a reference to an object of type ServiceEngineGroup. Field introduced
        /// in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_template_ref")]
        public string? SeGroupTemplateRef { get; set; }
        /// <summary>
        /// DNS records for VIPs are added/deleted based on the operational state of the VIPs. Field introduced in 17.1.12. Allowed
        /// in Basic(Allowed values- true) edition, Essentials(Allowed values- true) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "state_based_dns_registration")]
        public bool? StateBasedDnsRegistration { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Placeholder for description of property vca_configuration of obj type Cloud field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vca_configuration")]
        public NSXTALBvCloudAirConfigurationType VcaConfiguration { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_configuration of obj type Cloud field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_configuration")]
        public NSXTALBvCenterConfigurationType VcenterConfiguration { get; set; }
        /// <summary>
        /// This deployment is VMware on AWS cloud. Field introduced in 20.1.5, 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vmc_deployment")]
        public bool? VmcDeployment { get; set; }
        /// <summary>
        /// Cloud type. Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,
        /// CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT. Allowed in
        /// Basic(Allowed values- CLOUD_NONE,CLOUD_NSXT) edition, Essentials(Allowed values- CLOUD_NONE,CLOUD_VCENTER) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "vtype", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vtype { get; set; }
    }
}
