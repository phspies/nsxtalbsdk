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
    public class NSXTALBOpenStackConfigurationType 
    {
        /// <summary>
        /// OpenStack admin tenant (or project) information. For Keystone v3, provide the project information in project@domain
        /// format. Domain need not be specified if the project belongs to the 'Default' domain.
        /// </summary>
        [JsonProperty(PropertyName = "admin_tenant")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AdminTenant { get; set; }
        /// <summary>
        /// admin-tenant's UUID in OpenStack.
        /// </summary>
        [JsonProperty(PropertyName = "admin_tenant_uuid")]
        public string? AdminTenantUuid { get; set; }
        /// <summary>
        /// If false, allowed-address-pairs extension will not be used. .
        /// </summary>
        [JsonProperty(PropertyName = "allowed_address_pairs")]
        public bool? AllowedAddressPairs { get; set; }
        /// <summary>
        /// If true, an anti-affinity policy will be applied to all SEs of a SE-Group, else no such policy will be applied.
        /// </summary>
        [JsonProperty(PropertyName = "anti_affinity")]
        public bool? AntiAffinity { get; set; }
        /// <summary>
        /// Auth URL for connecting to keystone. If this is specified, any value provided for keystone_host is ignored.
        /// </summary>
        [JsonProperty(PropertyName = "auth_url")]
        public string? AuthUrl { get; set; }
        /// <summary>
        /// If false, metadata service will be used instead of  config-drive functionality to retrieve SE VM metadata.
        /// </summary>
        [JsonProperty(PropertyName = "config_drive")]
        public bool? ConfigDrive { get; set; }
        /// <summary>
        /// When set to True, the VIP and Data ports will be programmed to set virtual machine interface disable-policy. Please
        /// refer Contrail documentation for more on disable-policy. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "contrail_disable_policy")]
        public bool? ContrailDisablePolicy { get; set; }
        /// <summary>
        /// Contrail VNC endpoint url (example http //10.10.10.100 8082). By default, 'http //' scheme and 8082 port will be used if
        /// not provided in the url.
        /// </summary>
        [JsonProperty(PropertyName = "contrail_endpoint")]
        public string? ContrailEndpoint { get; set; }
        /// <summary>
        /// Enable Contrail plugin mode. (deprecated).
        /// </summary>
        [JsonProperty(PropertyName = "contrail_plugin")]
        public bool? ContrailPlugin { get; set; }
        /// <summary>
        /// Custom image properties to be set on a Service Engine image. Only hw_vif_multiqueue_enabled property is supported. Other
        /// properties will be ignored. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "custom_se_image_properties")]
        public IList<NSXTALBPropertyType> CustomSeImageProperties { get; set; }
        /// <summary>
        /// If True, allow selection of networks marked as 'external' for management,  vip or data networks.
        /// </summary>
        [JsonProperty(PropertyName = "external_networks")]
        public bool? ExternalNetworks { get; set; }
        /// <summary>
        /// Free unused floating IPs.
        /// </summary>
        [JsonProperty(PropertyName = "free_floatingips")]
        public bool? FreeFloatingips { get; set; }
        /// <summary>
        /// Default hypervisor type, only KVM is supported. Enum options - DEFAULT, VMWARE_ESX, KVM, VMWARE_VSAN, XEN.
        /// </summary>
        [JsonProperty(PropertyName = "hypervisor")]
        public string? Hypervisor { get; set; }
        /// <summary>
        /// Custom properties per hypervisor type. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "hypervisor_properties")]
        public IList<NSXTALBOpenStackHypervisorPropertiesType> HypervisorProperties { get; set; }
        /// <summary>
        /// If OS_IMG_FMT_RAW, use RAW images else use QCOW2 for KVM. Enum options - OS_IMG_FMT_AUTO, OS_IMG_FMT_QCOW2,
        /// OS_IMG_FMT_VMDK, OS_IMG_FMT_RAW, OS_IMG_FMT_FLAT.
        /// </summary>
        [JsonProperty(PropertyName = "img_format")]
        public string? ImgFormat { get; set; }
        /// <summary>
        /// Import keystone tenants list into Avi.
        /// </summary>
        [JsonProperty(PropertyName = "import_keystone_tenants")]
        public bool? ImportKeystoneTenants { get; set; }
        /// <summary>
        /// Allow self-signed certificates when communicating with https service endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "insecure")]
        public bool? Insecure { get; set; }
        /// <summary>
        /// If True, interface-secondary-ips method will be used for VIP association. Field deprecated in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "intf_sec_ips")]
        public bool? IntfSecIps { get; set; }
        /// <summary>
        /// Keystone's hostname or IP address. (Deprecated) Use auth_url instead.
        /// </summary>
        [JsonProperty(PropertyName = "keystone_host")]
        public string? KeystoneHost { get; set; }
        /// <summary>
        /// If True, map Avi 'admin' tenant to the admin_tenant of the Cloud. Else map Avi 'admin' to OpenStack 'admin' tenant.
        /// </summary>
        [JsonProperty(PropertyName = "map_admin_to_cloudadmin")]
        public bool? MapAdminToCloudadmin { get; set; }
        /// <summary>
        /// Avi Management network name or cidr.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_network_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MgmtNetworkName { get; set; }
        /// <summary>
        /// Management network UUID.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_network_uuid")]
        public string? MgmtNetworkUuid { get; set; }
        /// <summary>
        /// If True, embed owner info in VIP port 'name', else embed owner info in 'device_id' field.
        /// </summary>
        [JsonProperty(PropertyName = "name_owner")]
        public bool? NameOwner { get; set; }
        /// <summary>
        /// If True, enable neutron rbac discovery of networks shared across tenants/projects.
        /// </summary>
        [JsonProperty(PropertyName = "neutron_rbac")]
        public bool? NeutronRbac { get; set; }
        /// <summary>
        /// Field deprecated in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nuage_organization")]
        public string? NuageOrganization { get; set; }
        /// <summary>
        /// Field deprecated in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nuage_password")]
        public string? NuagePassword { get; set; }
        /// <summary>
        /// Field deprecated in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nuage_port")]
        public int? NuagePort { get; set; }
        /// <summary>
        /// Field deprecated in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nuage_username")]
        public string? NuageUsername { get; set; }
        /// <summary>
        /// Applicable only if allowed-address-pairs is disabled or unusable. VIP placement uses Nuage virtualIp if true, else
        /// redirectionTarget. Field deprecated in 20.1.1. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "nuage_virtualip")]
        public bool? NuageVirtualip { get; set; }
        /// <summary>
        /// Nuage VSD host name or IP address. Field deprecated in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nuage_vsd_host")]
        public string? NuageVsdHost { get; set; }
        /// <summary>
        /// The password Avi Vantage will use when authenticating to Keystone.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// If true, port-security extension (if detected) will be used instead of security-groups, allowed-address-pairs or
        /// interface-secondary-ips. If false, port-security extension is skipped. Field deprecated in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "port_security")]
        public bool? PortSecurity { get; set; }
        /// <summary>
        /// Access privilege. Enum options - NO_ACCESS, READ_ACCESS, WRITE_ACCESS.
        /// </summary>
        [JsonProperty(PropertyName = "privilege")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Privilege { get; set; }
        /// <summary>
        /// LBaaS provider name.
        /// </summary>
        [JsonProperty(PropertyName = "prov_name")]
        public IList<string> ProvName { get; set; }
        /// <summary>
        /// A tenant can normally use its own networks and any networks shared with it. In addition, this setting provides extra
        /// networks that are usable by tenants. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "provider_vip_networks")]
        public IList<NSXTALBOpenStackVipNetworkType> ProviderVipNetworks { get; set; }
        /// <summary>
        /// Region name.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string? Region { get; set; }
        /// <summary>
        /// Defines the mapping from OpenStack role names to avi local role names. For an OpenStack role, this mapping is consulted
        /// only if there is no local Avi role with the same name as the OpenStack role. This is an ordered list and only the first
        /// matching entry is used. You can use '*' to match all OpenStack role names.
        /// </summary>
        [JsonProperty(PropertyName = "role_mapping")]
        public IList<NSXTALBOpenStackRoleMappingType> RoleMapping { get; set; }
        /// <summary>
        /// This field has been generalized for all clouds and has been renamed to se_group_template_uuid. It is a reference to an
        /// object of type ServiceEngineGroup. Field deprecated in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_ref")]
        public string? SeGroupRef { get; set; }
        /// <summary>
        /// If false, security-groups extension will not be used. .
        /// </summary>
        [JsonProperty(PropertyName = "security_groups")]
        public bool? SecurityGroups { get; set; }
        /// <summary>
        /// If true, then SEs will be created in the appropriate tenants, else SEs will be created in the admin_tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_se")]
        public bool? TenantSe { get; set; }
        /// <summary>
        /// Deprecated, please use provider_vip_networks. Field deprecated in 18.2.2. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "usable_network_uuids")]
        public IList<string> UsableNetworkUuids { get; set; }
        /// <summary>
        /// If admin URLs are either inaccessible or not to be accessed from Avi Controller, then set this to False.
        /// </summary>
        [JsonProperty(PropertyName = "use_admin_url")]
        public bool? UseAdminUrl { get; set; }
        /// <summary>
        /// Use internalURL for OpenStack endpoints instead of the default publicURL endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "use_internal_endpoints")]
        public bool? UseInternalEndpoints { get; set; }
        /// <summary>
        /// Use keystone for user authentication.
        /// </summary>
        [JsonProperty(PropertyName = "use_keystone_auth")]
        public bool? UseKeystoneAuth { get; set; }
        /// <summary>
        /// If True, use nuage vip as device_owner of VIP ports, else use neutron LOADBALANCER. Field deprecated in 20.1.1. Field
        /// introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "use_nuagevip")]
        public bool? UseNuagevip { get; set; }
        /// <summary>
        /// The username Avi Vantage will use when authenticating to Keystone. For Keystone v3, provide the user information in
        /// user@domain format, unless that user belongs to the Default domain.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Username { get; set; }
        /// <summary>
        /// If enabled, program SE security group with ingress rule to allow SSH (port 22) access from 0.0.0.0/0. Field deprecated
        /// in 17.1.5. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "wildcard_access")]
        public bool? WildcardAccess { get; set; }
    }
}
