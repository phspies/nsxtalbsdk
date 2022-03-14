using System;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using nsxtalbsdk.Modules;

namespace nsxtalbapi
{
    public class NSXTALBClient
    {
        public string EndPoint { get; set; }
        public RestClient restClient { get; set; }
        JsonSerializerSettings defaultSerializationSettings;
        public NSXTALBClient(string host, string Username, string Password, bool? remoteCertificateValidation = true, JsonSerializerSettings? DefaultSerializationSettings = null, int Port = 443)
        {
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
        public ActionGroupConfig ActionGroupConfigModule => new ActionGroupConfig(restClient, defaultSerializationSettings);
        public AlbservicesConfig AlbservicesConfigModule => new AlbservicesConfig(restClient, defaultSerializationSettings);
        public AlbservicesFileUpload AlbservicesFileUploadModule => new AlbservicesFileUpload(restClient, defaultSerializationSettings);
        public AlbservicesJob AlbservicesJobModule => new AlbservicesJob(restClient, defaultSerializationSettings);
        public Alert AlertModule => new Alert(restClient, defaultSerializationSettings);
        public AlertConfig AlertConfigModule => new AlertConfig(restClient, defaultSerializationSettings);
        public AlertEmailConfig AlertEmailConfigModule => new AlertEmailConfig(restClient, defaultSerializationSettings);
        public AlertObjectList AlertObjectListModule => new AlertObjectList(restClient, defaultSerializationSettings);
        public AlertScriptConfig AlertScriptConfigModule => new AlertScriptConfig(restClient, defaultSerializationSettings);
        public AlertSyslogConfig AlertSyslogConfigModule => new AlertSyslogConfig(restClient, defaultSerializationSettings);
        public AnalyticsProfile AnalyticsProfileModule => new AnalyticsProfile(restClient, defaultSerializationSettings);
        public Anomaly AnomalyModule => new Anomaly(restClient, defaultSerializationSettings);
        public ApiclifsRuntime ApiclifsRuntimeModule => new ApiclifsRuntime(restClient, defaultSerializationSettings);
        public Application ApplicationModule => new Application(restClient, defaultSerializationSettings);
        public ApplicationPersistenceProfile ApplicationPersistenceProfileModule => new ApplicationPersistenceProfile(restClient, defaultSerializationSettings);
        public ApplicationProfile ApplicationProfileModule => new ApplicationProfile(restClient, defaultSerializationSettings);
        public AuthProfile AuthProfileModule => new AuthProfile(restClient, defaultSerializationSettings);
        public AutoScaleLaunchConfig AutoScaleLaunchConfigModule => new AutoScaleLaunchConfig(restClient, defaultSerializationSettings);
        public AvailabilityZone AvailabilityZoneModule => new AvailabilityZone(restClient, defaultSerializationSettings);
        public Backup BackupModule => new Backup(restClient, defaultSerializationSettings);
        public BackupConfiguration BackupConfigurationModule => new BackupConfiguration(restClient, defaultSerializationSettings);
        public BotConfigConsolidator BotConfigConsolidatorModule => new BotConfigConsolidator(restClient, defaultSerializationSettings);
        public BotDetectionPolicy BotDetectionPolicyModule => new BotDetectionPolicy(restClient, defaultSerializationSettings);
        public BotIpreputationTypeMapping BotIpreputationTypeMappingModule => new BotIpreputationTypeMapping(restClient, defaultSerializationSettings);
        public BotMapping BotMappingModule => new BotMapping(restClient, defaultSerializationSettings);
        public CertificateManagementProfile CertificateManagementProfileModule => new CertificateManagementProfile(restClient, defaultSerializationSettings);
        public Cloud CloudModule => new Cloud(restClient, defaultSerializationSettings);
        public CloudConnectorUser CloudConnectorUserModule => new CloudConnectorUser(restClient, defaultSerializationSettings);
        public CloudProperties CloudPropertiesModule => new CloudProperties(restClient, defaultSerializationSettings);
        public CloudRuntime CloudRuntimeModule => new CloudRuntime(restClient, defaultSerializationSettings);
        public Cluster ClusterModule => new Cluster(restClient, defaultSerializationSettings);
        public ClusterCloudDetails ClusterCloudDetailsModule => new ClusterCloudDetails(restClient, defaultSerializationSettings);
        public ControllerLicense ControllerLicenseModule => new ControllerLicense(restClient, defaultSerializationSettings);
        public ControllerPortalRegistration ControllerPortalRegistrationModule => new ControllerPortalRegistration(restClient, defaultSerializationSettings);
        public ControllerProperties ControllerPropertiesModule => new ControllerProperties(restClient, defaultSerializationSettings);
        public ControllerSite ControllerSiteModule => new ControllerSite(restClient, defaultSerializationSettings);
        public CustomerPortalInfo CustomerPortalInfoModule => new CustomerPortalInfo(restClient, defaultSerializationSettings);
        public CustomIpamDnsProfile CustomIpamDnsProfileModule => new CustomIpamDnsProfile(restClient, defaultSerializationSettings);
        public DebugController DebugControllerModule => new DebugController(restClient, defaultSerializationSettings);
        public DebugServiceEngine DebugServiceEngineModule => new DebugServiceEngine(restClient, defaultSerializationSettings);
        public DebugVirtualService DebugVirtualServiceModule => new DebugVirtualService(restClient, defaultSerializationSettings);
        public DnsPolicy DnsPolicyModule => new DnsPolicy(restClient, defaultSerializationSettings);
        public DynamicDnsRecord DynamicDnsRecordModule => new DynamicDnsRecord(restClient, defaultSerializationSettings);
        public ErrorPageBody ErrorPageBodyModule => new ErrorPageBody(restClient, defaultSerializationSettings);
        public ErrorPageProfile ErrorPageProfileModule => new ErrorPageProfile(restClient, defaultSerializationSettings);
        public FederationCheckpoint FederationCheckpointModule => new FederationCheckpoint(restClient, defaultSerializationSettings);
        public FileObject FileObjectModule => new FileObject(restClient, defaultSerializationSettings);
        public GeoDB GeoDBModule => new GeoDB(restClient, defaultSerializationSettings);
        public Gslb GslbModule => new Gslb(restClient, defaultSerializationSettings);
        public GslbGeoDbProfile GslbGeoDbProfileModule => new GslbGeoDbProfile(restClient, defaultSerializationSettings);
        public GslbService GslbServiceModule => new GslbService(restClient, defaultSerializationSettings);
        public HardwareSecurityModuleGroup HardwareSecurityModuleGroupModule => new HardwareSecurityModuleGroup(restClient, defaultSerializationSettings);
        public HealthMonitor HealthMonitorModule => new HealthMonitor(restClient, defaultSerializationSettings);
        public Healthscore HealthscoreModule => new Healthscore(restClient, defaultSerializationSettings);
        public HttppolicySet HttppolicySetModule => new HttppolicySet(restClient, defaultSerializationSettings);
        public IcapProfile IcapProfileModule => new IcapProfile(restClient, defaultSerializationSettings);
        public Image ImageModule => new Image(restClient, defaultSerializationSettings);
        public InventoryFaultConfig InventoryFaultConfigModule => new InventoryFaultConfig(restClient, defaultSerializationSettings);
        public IpAddrGroup IpAddrGroupModule => new IpAddrGroup(restClient, defaultSerializationSettings);
        public IpamDnsProviderProfile IpamDnsProviderProfileModule => new IpamDnsProviderProfile(restClient, defaultSerializationSettings);
        public IpreputationDB IpreputationDBModule => new IpreputationDB(restClient, defaultSerializationSettings);
        public JobEntry JobEntryModule => new JobEntry(restClient, defaultSerializationSettings);
        public Jwtprofile JwtprofileModule => new Jwtprofile(restClient, defaultSerializationSettings);
        public JwtserverProfile JwtserverProfileModule => new JwtserverProfile(restClient, defaultSerializationSettings);
        public L4PolicySet L4PolicySetModule => new L4PolicySet(restClient, defaultSerializationSettings);
        public LabelGroup LabelGroupModule => new LabelGroup(restClient, defaultSerializationSettings);
        public LicenseLedgerDetails LicenseLedgerDetailsModule => new LicenseLedgerDetails(restClient, defaultSerializationSettings);
        public LicenseStatus LicenseStatusModule => new LicenseStatus(restClient, defaultSerializationSettings);
        public LogControllerMapping LogControllerMappingModule => new LogControllerMapping(restClient, defaultSerializationSettings);
        public MemoryBalancerRequest MemoryBalancerRequestModule => new MemoryBalancerRequest(restClient, defaultSerializationSettings);
        public Metrics MetricsModule => new Metrics(restClient, defaultSerializationSettings);
        public MicroService MicroServiceModule => new MicroService(restClient, defaultSerializationSettings);
        public MicroServiceGroup MicroServiceGroupModule => new MicroServiceGroup(restClient, defaultSerializationSettings);
        public NatPolicy NatPolicyModule => new NatPolicy(restClient, defaultSerializationSettings);
        public Network NetworkModule => new Network(restClient, defaultSerializationSettings);
        public NetworkProfile NetworkProfileModule => new NetworkProfile(restClient, defaultSerializationSettings);
        public NetworkRuntime NetworkRuntimeModule => new NetworkRuntime(restClient, defaultSerializationSettings);
        public NetworkSecurityPolicy NetworkSecurityPolicyModule => new NetworkSecurityPolicy(restClient, defaultSerializationSettings);
        public NetworkService NetworkServiceModule => new NetworkService(restClient, defaultSerializationSettings);
        public NsxtSegmentRuntime NsxtSegmentRuntimeModule => new NsxtSegmentRuntime(restClient, defaultSerializationSettings);
        public ObjectAccessPolicy ObjectAccessPolicyModule => new ObjectAccessPolicy(restClient, defaultSerializationSettings);
        public PingAccessAgent PingAccessAgentModule => new PingAccessAgent(restClient, defaultSerializationSettings);
        public Pkiprofile PkiprofileModule => new Pkiprofile(restClient, defaultSerializationSettings);
        public Pool PoolModule => new Pool(restClient, defaultSerializationSettings);
        public PoolGroup PoolGroupModule => new PoolGroup(restClient, defaultSerializationSettings);
        public PoolGroupDeploymentPolicy PoolGroupDeploymentPolicyModule => new PoolGroupDeploymentPolicy(restClient, defaultSerializationSettings);
        public PortalFileUpload PortalFileUploadModule => new PortalFileUpload(restClient, defaultSerializationSettings);
        public PriorityLabels PriorityLabelsModule => new PriorityLabels(restClient, defaultSerializationSettings);
        public ProtocolParser ProtocolParserModule => new ProtocolParser(restClient, defaultSerializationSettings);
        public Role RoleModule => new Role(restClient, defaultSerializationSettings);
        public Scheduler SchedulerModule => new Scheduler(restClient, defaultSerializationSettings);
        public ScpoolServerStateInfo ScpoolServerStateInfoModule => new ScpoolServerStateInfo(restClient, defaultSerializationSettings);
        public ScvsStateInfo ScvsStateInfoModule => new ScvsStateInfo(restClient, defaultSerializationSettings);
        public SecureChannelAvailableLocalIps SecureChannelAvailableLocalIpsModule => new SecureChannelAvailableLocalIps(restClient, defaultSerializationSettings);
        public SecureChannelMapping SecureChannelMappingModule => new SecureChannelMapping(restClient, defaultSerializationSettings);
        public SecureChannelToken SecureChannelTokenModule => new SecureChannelToken(restClient, defaultSerializationSettings);
        public SecurityManagerData SecurityManagerDataModule => new SecurityManagerData(restClient, defaultSerializationSettings);
        public SecurityPolicy SecurityPolicyModule => new SecurityPolicy(restClient, defaultSerializationSettings);
        public SeProperties SePropertiesModule => new SeProperties(restClient, defaultSerializationSettings);
        public ServerAutoScalePolicy ServerAutoScalePolicyModule => new ServerAutoScalePolicy(restClient, defaultSerializationSettings);
        public ServiceEngine ServiceEngineModule => new ServiceEngine(restClient, defaultSerializationSettings);
        public ServiceEngineGroup ServiceEngineGroupModule => new ServiceEngineGroup(restClient, defaultSerializationSettings);
        public ServiceEnginePolicy ServiceEnginePolicyModule => new ServiceEnginePolicy(restClient, defaultSerializationSettings);
        public SiteVersion SiteVersionModule => new SiteVersion(restClient, defaultSerializationSettings);
        public SnmpTrapProfile SnmpTrapProfileModule => new SnmpTrapProfile(restClient, defaultSerializationSettings);
        public SslkeyAndCertificate SslkeyAndCertificateModule => new SslkeyAndCertificate(restClient, defaultSerializationSettings);
        public Sslprofile SslprofileModule => new Sslprofile(restClient, defaultSerializationSettings);
        public Ssopolicy SsopolicyModule => new Ssopolicy(restClient, defaultSerializationSettings);
        public StatediffOperation StatediffOperationModule => new StatediffOperation(restClient, defaultSerializationSettings);
        public StatediffSnapshot StatediffSnapshotModule => new StatediffSnapshot(restClient, defaultSerializationSettings);
        public StringGroup StringGroupModule => new StringGroup(restClient, defaultSerializationSettings);
        public SystemConfiguration SystemConfigurationModule => new SystemConfiguration(restClient, defaultSerializationSettings);
        public SystemLimits SystemLimitsModule => new SystemLimits(restClient, defaultSerializationSettings);
        public Tenant TenantModule => new Tenant(restClient, defaultSerializationSettings);
        public TestSeDatastoreLevel1 TestSeDatastoreLevel1Module => new TestSeDatastoreLevel1(restClient, defaultSerializationSettings);
        public TestSeDatastoreLevel2 TestSeDatastoreLevel2Module => new TestSeDatastoreLevel2(restClient, defaultSerializationSettings);
        public TestSeDatastoreLevel3 TestSeDatastoreLevel3Module => new TestSeDatastoreLevel3(restClient, defaultSerializationSettings);
        public TrafficCloneProfile TrafficCloneProfileModule => new TrafficCloneProfile(restClient, defaultSerializationSettings);
        public UpgradeStatusInfo UpgradeStatusInfoModule => new UpgradeStatusInfo(restClient, defaultSerializationSettings);
        public UpgradeStatusSummary UpgradeStatusSummaryModule => new UpgradeStatusSummary(restClient, defaultSerializationSettings);
        public User UserModule => new User(restClient, defaultSerializationSettings);
        public UserAccountProfile UserAccountProfileModule => new UserAccountProfile(restClient, defaultSerializationSettings);
        public UserActivity UserActivityModule => new UserActivity(restClient, defaultSerializationSettings);
        public VcenterServer VcenterServerModule => new VcenterServer(restClient, defaultSerializationSettings);
        public Vidcinfo VidcinfoModule => new Vidcinfo(restClient, defaultSerializationSettings);
        public VimgrClusterRuntime VimgrClusterRuntimeModule => new VimgrClusterRuntime(restClient, defaultSerializationSettings);
        public VimgrControllerRuntime VimgrControllerRuntimeModule => new VimgrControllerRuntime(restClient, defaultSerializationSettings);
        public VimgrDcruntime VimgrDcruntimeModule => new VimgrDcruntime(restClient, defaultSerializationSettings);
        public VimgrHostRuntime VimgrHostRuntimeModule => new VimgrHostRuntime(restClient, defaultSerializationSettings);
        public VimgrNwruntime VimgrNwruntimeModule => new VimgrNwruntime(restClient, defaultSerializationSettings);
        public VimgrSevmruntime VimgrSevmruntimeModule => new VimgrSevmruntime(restClient, defaultSerializationSettings);
        public VimgrVcenterRuntime VimgrVcenterRuntimeModule => new VimgrVcenterRuntime(restClient, defaultSerializationSettings);
        public VimgrVmruntime VimgrVmruntimeModule => new VimgrVmruntime(restClient, defaultSerializationSettings);
        public VipgnameInfo VipgnameInfoModule => new VipgnameInfo(restClient, defaultSerializationSettings);
        public VirtualService VirtualServiceModule => new VirtualService(restClient, defaultSerializationSettings);
        public VrfContext VrfContextModule => new VrfContext(restClient, defaultSerializationSettings);
        public VsdataScriptSet VsdataScriptSetModule => new VsdataScriptSet(restClient, defaultSerializationSettings);
        public VsGs VsGsModule => new VsGs(restClient, defaultSerializationSettings);
        public VsVip VsVipModule => new VsVip(restClient, defaultSerializationSettings);
        public WafApplicationSignatureProvider WafApplicationSignatureProviderModule => new WafApplicationSignatureProvider(restClient, defaultSerializationSettings);
        public WafCRS WafCRSModule => new WafCRS(restClient, defaultSerializationSettings);
        public WafPolicy WafPolicyModule => new WafPolicy(restClient, defaultSerializationSettings);
        public WafPolicyPsmgroup WafPolicyPsmgroupModule => new WafPolicyPsmgroup(restClient, defaultSerializationSettings);
        public WafProfile WafProfileModule => new WafProfile(restClient, defaultSerializationSettings);
        public Webhook WebhookModule => new Webhook(restClient, defaultSerializationSettings);
    }
}