using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsxtalbsdk.Authentication
{
    public class LoginResponseType
    {
        [JsonProperty("user_initialized")]
        public bool UserInitialized { get; set; }

        [JsonProperty("version")]
        public VersionType Version { get; set; }

        [JsonProperty("user")]
        public UserType User { get; set; }

        [JsonProperty("tenants")]
        public List<TenantType> Tenants { get; set; }

        [JsonProperty("system_config")]
        public SystemConfigType SystemConfig { get; set; }

        [JsonProperty("controller")]
        public ControllerType Controller { get; set; }

        [JsonProperty("session_cookie_name")]
        public string SessionCookieName { get; set; }
    }



    public class VersionType
    {
        [JsonProperty("Date")]
        public DateTime Date { get; set; }

        [JsonProperty("Tag")]
        public string Tag { get; set; }

        [JsonProperty("Version")]
        public string Version { get; set; }

        [JsonProperty("build")]
        public int Build { get; set; }

        [JsonProperty("min_version")]
        public string MinVersion { get; set; }

        [JsonProperty("Product")]
        public string Product { get; set; }

        [JsonProperty("ProductName")]
        public string ProductName { get; set; }

        [JsonProperty("patch")]
        public string Patch { get; set; }
    }

    public class UserType
    {
        [JsonProperty("is_superuser")]
        public bool IsSuperuser { get; set; }

        [JsonProperty("default_tenant_ref")]
        public string DefaultTenantRef { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("local")]
        public bool Local { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("ui_property")]
        public string UiProperty { get; set; }
    }

    public class TenantType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("local")]
        public bool Local { get; set; }

        [JsonProperty("enforce_label_group")]
        public bool EnforceLabelGroup { get; set; }

        [JsonProperty("macro_in_progress")]
        public int MacroInProgress { get; set; }

        [JsonProperty("tenant_force_delete_in_progress")]
        public bool TenantForceDeleteInProgress { get; set; }
    }

    public class ServerListType
    {
        [JsonProperty("addr")]
        public string Addr { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DnsConfigurationType
    {
        [JsonProperty("server_list")]
        public List<ServerListType> ServerList { get; set; }

        [JsonProperty("search_domain")]
        public string SearchDomain { get; set; }
    }

    public class ServerType
    {
        [JsonProperty("addr")]
        public string Addr { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class NtpServerType
    {
        [JsonProperty("server")]
        public ServerType Server { get; set; }
    }

    public class NtpConfiguration
    {
        [JsonProperty("ntp_servers")]
        public List<NtpServerType> NtpServers { get; set; }
    }

    public class PortalConfigurationType
    {
        [JsonProperty("enable_https")]
        public bool EnableHttps { get; set; }

        [JsonProperty("redirect_to_https")]
        public bool RedirectToHttps { get; set; }

        [JsonProperty("enable_http")]
        public bool EnableHttp { get; set; }

        [JsonProperty("use_uuid_from_input")]
        public bool UseUuidFromInput { get; set; }

        [JsonProperty("enable_clickjacking_protection")]
        public bool EnableClickjackingProtection { get; set; }

        [JsonProperty("allow_basic_authentication")]
        public bool AllowBasicAuthentication { get; set; }

        [JsonProperty("password_strength_check")]
        public bool PasswordStrengthCheck { get; set; }

        [JsonProperty("disable_remote_cli_shell")]
        public bool DisableRemoteCliShell { get; set; }

        [JsonProperty("disable_swagger")]
        public bool DisableSwagger { get; set; }

        [JsonProperty("api_force_timeout")]
        public int ApiForceTimeout { get; set; }

        [JsonProperty("minimum_password_length")]
        public int MinimumPasswordLength { get; set; }

        [JsonProperty("sslkeyandcertificate_refs")]
        public List<string> SslkeyandcertificateRefs { get; set; }

        [JsonProperty("sslprofile_ref")]
        public string SslprofileRef { get; set; }
    }

    public class GlobalTenantConfigType
    {
        [JsonProperty("tenant_vrf")]
        public bool TenantVrf { get; set; }

        [JsonProperty("se_in_provider_context")]
        public bool SeInProviderContext { get; set; }

        [JsonProperty("tenant_access_to_provider_se")]
        public bool TenantAccessToProviderSe { get; set; }
    }

    public class EmailConfigurationType
    {
        [JsonProperty("smtp_type")]
        public string SmtpType { get; set; }

        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        [JsonProperty("mail_server_name")]
        public string MailServerName { get; set; }

        [JsonProperty("mail_server_port")]
        public int MailServerPort { get; set; }

        [JsonProperty("disable_tls")]
        public bool DisableTls { get; set; }
    }

    public class SecureChannelConfigurationType
    {
        [JsonProperty("sslkeyandcertificate_refs")]
        public List<string> SslkeyandcertificateRefs { get; set; }
    }

    public class SystemConfigType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("_last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("dns_configuration")]
        public DnsConfigurationType DnsConfiguration { get; set; }

        [JsonProperty("ntp_configuration")]
        public NtpConfiguration NtpConfiguration { get; set; }

        [JsonProperty("portal_configuration")]
        public PortalConfigurationType PortalConfiguration { get; set; }

        [JsonProperty("global_tenant_config")]
        public GlobalTenantConfigType GlobalTenantConfig { get; set; }

        [JsonProperty("email_configuration")]
        public EmailConfigurationType EmailConfiguration { get; set; }

        [JsonProperty("docker_mode")]
        public bool DockerMode { get; set; }

        [JsonProperty("ssh_ciphers")]
        public List<string> SshCiphers { get; set; }

        [JsonProperty("ssh_hmacs")]
        public List<string> SshHmacs { get; set; }

        [JsonProperty("default_license_tier")]
        public string DefaultLicenseTier { get; set; }

        [JsonProperty("secure_channel_configuration")]
        public SecureChannelConfigurationType SecureChannelConfiguration { get; set; }

        [JsonProperty("welcome_workflow_complete")]
        public bool WelcomeWorkflowComplete { get; set; }

        [JsonProperty("fips_mode")]
        public bool FipsMode { get; set; }

        [JsonProperty("enable_cors")]
        public bool EnableCors { get; set; }

        [JsonProperty("common_criteria_mode")]
        public bool CommonCriteriaMode { get; set; }

        [JsonProperty("dns_virtualservice_refs")]
        public List<string> DnsVirtualserviceRefs { get; set; }
    }

    public class ControllerType
    {
        [JsonProperty("api_idle_timeout")]
        public int ApiIdleTimeout { get; set; }
    }

   


}
