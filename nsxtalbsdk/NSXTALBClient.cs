using System;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using nsxtalbsdk.Modules;
using System.Threading;

namespace nsxtalbapi
{
    public class NSXTALBClient
    {
        public RestClient restClient { get; set; }
        private JsonSerializerSettings defaultSerializationSettings;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        public NSXTALBClient(string host, string Username, string Password, bool? remoteCertificateValidation = true, JsonSerializerSettings? DefaultSerializationSettings = null, CancellationToken _cancellationToken = default(CancellationToken), int Port = 443, int _timeout = 5, int _retry = 2)
        {
            cancellationToken = _cancellationToken;
            timeout = _timeout;
            retry = _retry;
            var uri = new UriBuilder(host)
            {
                Scheme = Uri.UriSchemeHttps,
                Port = Port
            };
            restClient = new RestClient(uri.Uri);
            if (remoteCertificateValidation == false)
            {
                restClient.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
            }            
            restClient.Authenticator = new HttpBasicAuthenticator(Username, Password);
            if (DefaultSerializationSettings == null)
            {
                defaultSerializationSettings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    DefaultValueHandling = DefaultValueHandling.Include,
                    TypeNameHandling = TypeNameHandling.None,
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.None,
                    ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
                };
            }
            else
            {
                defaultSerializationSettings = DefaultSerializationSettings;
            }
            restClient.UseNewtonsoftJson(defaultSerializationSettings);
        }
        public ActionGroupConfig ActionGroupConfigModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public AlbservicesConfig AlbservicesConfigModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public AlbservicesFileUpload AlbservicesFileUploadModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public AlbservicesJob AlbservicesJobModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Alert AlertModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public AlertConfig AlertConfigModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public AlertEmailConfig AlertEmailConfigModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public AlertObjectList AlertObjectListModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public AlertScriptConfig AlertScriptConfigModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public AlertSyslogConfig AlertSyslogConfigModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public AnalyticsProfile AnalyticsProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Anomaly AnomalyModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ApiclifsRuntime ApiclifsRuntimeModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Application ApplicationModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ApplicationPersistenceProfile ApplicationPersistenceProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ApplicationProfile ApplicationProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public AuthProfile AuthProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public AutoScaleLaunchConfig AutoScaleLaunchConfigModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public AvailabilityZone AvailabilityZoneModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Backup BackupModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public BackupConfiguration BackupConfigurationModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public BotConfigConsolidator BotConfigConsolidatorModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public BotDetectionPolicy BotDetectionPolicyModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public BotIpreputationTypeMapping BotIpreputationTypeMappingModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public BotMapping BotMappingModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public CertificateManagementProfile CertificateManagementProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Cloud CloudModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public CloudConnectorUser CloudConnectorUserModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public CloudProperties CloudPropertiesModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public CloudRuntime CloudRuntimeModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Cluster ClusterModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ClusterCloudDetails ClusterCloudDetailsModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ControllerLicense ControllerLicenseModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ControllerPortalRegistration ControllerPortalRegistrationModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ControllerProperties ControllerPropertiesModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ControllerSite ControllerSiteModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public CustomerPortalInfo CustomerPortalInfoModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public CustomIpamDnsProfile CustomIpamDnsProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public DebugController DebugControllerModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public DebugServiceEngine DebugServiceEngineModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public DebugVirtualService DebugVirtualServiceModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public DnsPolicy DnsPolicyModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public DynamicDnsRecord DynamicDnsRecordModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ErrorPageBody ErrorPageBodyModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ErrorPageProfile ErrorPageProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public FederationCheckpoint FederationCheckpointModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public FileObject FileObjectModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public GeoDB GeoDBModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Gslb GslbModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public GslbGeoDbProfile GslbGeoDbProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public GslbService GslbServiceModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public HardwareSecurityModuleGroup HardwareSecurityModuleGroupModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public HealthMonitor HealthMonitorModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Healthscore HealthscoreModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public HttppolicySet HttppolicySetModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public IcapProfile IcapProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Image ImageModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public InventoryFaultConfig InventoryFaultConfigModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public IpAddrGroup IpAddrGroupModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public IpamDnsProviderProfile IpamDnsProviderProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public IpreputationDB IpreputationDBModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public JobEntry JobEntryModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Jwtprofile JwtprofileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public JwtserverProfile JwtserverProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public L4PolicySet L4PolicySetModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public LabelGroup LabelGroupModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public LicenseLedgerDetails LicenseLedgerDetailsModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public LicenseStatus LicenseStatusModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public LogControllerMapping LogControllerMappingModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public MemoryBalancerRequest MemoryBalancerRequestModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Metrics MetricsModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public MicroService MicroServiceModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public MicroServiceGroup MicroServiceGroupModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public NatPolicy NatPolicyModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Network NetworkModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public NetworkProfile NetworkProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public NetworkRuntime NetworkRuntimeModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public NetworkSecurityPolicy NetworkSecurityPolicyModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public NetworkService NetworkServiceModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public NsxtSegmentRuntime NsxtSegmentRuntimeModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ObjectAccessPolicy ObjectAccessPolicyModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PingAccessAgent PingAccessAgentModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Pkiprofile PkiprofileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Pool PoolModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PoolGroup PoolGroupModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PoolGroupDeploymentPolicy PoolGroupDeploymentPolicyModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PortalFileUpload PortalFileUploadModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PriorityLabels PriorityLabelsModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ProtocolParser ProtocolParserModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Role RoleModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Scheduler SchedulerModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ScpoolServerStateInfo ScpoolServerStateInfoModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ScvsStateInfo ScvsStateInfoModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public SecureChannelAvailableLocalIps SecureChannelAvailableLocalIpsModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public SecureChannelMapping SecureChannelMappingModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public SecureChannelToken SecureChannelTokenModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public SecurityManagerData SecurityManagerDataModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public SecurityPolicy SecurityPolicyModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public SeProperties SePropertiesModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ServerAutoScalePolicy ServerAutoScalePolicyModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ServiceEngine ServiceEngineModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ServiceEngineGroup ServiceEngineGroupModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ServiceEnginePolicy ServiceEnginePolicyModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public SiteVersion SiteVersionModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public SnmpTrapProfile SnmpTrapProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public SslkeyAndCertificate SslkeyAndCertificateModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Sslprofile SslprofileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Ssopolicy SsopolicyModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public StatediffOperation StatediffOperationModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public StatediffSnapshot StatediffSnapshotModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public StringGroup StringGroupModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public SystemConfiguration SystemConfigurationModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public SystemLimits SystemLimitsModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Tenant TenantModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public TestSeDatastoreLevel1 TestSeDatastoreLevel1Module => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public TestSeDatastoreLevel2 TestSeDatastoreLevel2Module => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public TestSeDatastoreLevel3 TestSeDatastoreLevel3Module => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public TrafficCloneProfile TrafficCloneProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public UpgradeStatusInfo UpgradeStatusInfoModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public UpgradeStatusSummary UpgradeStatusSummaryModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public User UserModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public UserAccountProfile UserAccountProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public UserActivity UserActivityModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VcenterServer VcenterServerModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Vidcinfo VidcinfoModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VimgrClusterRuntime VimgrClusterRuntimeModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VimgrControllerRuntime VimgrControllerRuntimeModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VimgrDcruntime VimgrDcruntimeModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VimgrHostRuntime VimgrHostRuntimeModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VimgrNwruntime VimgrNwruntimeModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VimgrSevmruntime VimgrSevmruntimeModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VimgrVcenterRuntime VimgrVcenterRuntimeModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VimgrVmruntime VimgrVmruntimeModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VipgnameInfo VipgnameInfoModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VirtualService VirtualServiceModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VrfContext VrfContextModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VsdataScriptSet VsdataScriptSetModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VsGs VsGsModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VsVip VsVipModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public WafApplicationSignatureProvider WafApplicationSignatureProviderModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public WafCRS WafCRSModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public WafPolicy WafPolicyModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public WafPolicyPsmgroup WafPolicyPsmgroupModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public WafProfile WafProfileModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Webhook WebhookModule => new(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
    }
}