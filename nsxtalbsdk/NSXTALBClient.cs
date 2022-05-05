using System;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using nsxtalbsdk.Modules;
using System.Threading;
using System.Threading.Tasks;
using nsxtalbsdk.Authentication;
using System.Linq;
using System.Collections.Generic;

namespace nsxtalbsdk
{
    public class NSXTALBClientAsync
    {
        public RestClient restClient { get; set; }
        private JsonSerializerSettings defaultSerializationSettings;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        private string defaultXAviVerion;
        private RestResponseCookie sessionCookie;
        private List<RestResponseCookie> sessionCookies;
        public async Task LoginAsync(string host, string Username, string Password, bool? remoteCertificateValidation = true, JsonSerializerSettings? DefaultSerializationSettings = null, CancellationToken _cancellationToken = default(CancellationToken), int Port = 443, int _timeout = 5, int _retry = 2, string _defaultXAviVerion = null)
        {
            cancellationToken = _cancellationToken;
            timeout = _timeout;
            retry = _retry;
            defaultXAviVerion = _defaultXAviVerion;
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

            LoginRequestType credentials = new LoginRequestType()
            {
                Username = Username,
                Password = Password
            };
            var response = await AuthenticationHelper.LoginAsync(credentials, restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
            sessionCookie = response.Cookies.FirstOrDefault(x => x.Name == response.Data.SessionCookieName);
            sessionCookies = response.Cookies.ToList();
            if (sessionCookie == null)
            {
                throw new NSXTALBException("Cookie variable not found", (int)response.StatusCode, response.Content, response.Headers);
            }
            if (defaultXAviVerion == null)
            {
                defaultXAviVerion = response.Data.Version.MinVersion;
            }

        }
        public async Task LogoutAsync()
        {
            AuthenticationHelper.Logout(sessionCookies, restClient);
        }
        public ClusterRuntime ClusterRuntimeModule => new ClusterRuntime(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);

        public ActionGroupConfig ActionGroupConfigModule => new ActionGroupConfig(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlbservicesConfig AlbservicesConfigModule => new AlbservicesConfig(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlbservicesFileUpload AlbservicesFileUploadModule => new AlbservicesFileUpload(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlbservicesJob AlbservicesJobModule => new AlbservicesJob(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Alert AlertModule => new Alert(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertConfig AlertConfigModule => new AlertConfig(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertEmailConfig AlertEmailConfigModule => new AlertEmailConfig(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertObjectList AlertObjectListModule => new AlertObjectList(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertScriptConfig AlertScriptConfigModule => new AlertScriptConfig(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertSyslogConfig AlertSyslogConfigModule => new AlertSyslogConfig(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AnalyticsProfile AnalyticsProfileModule => new AnalyticsProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Anomaly AnomalyModule => new Anomaly(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ApiclifsRuntime ApiclifsRuntimeModule => new ApiclifsRuntime(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Application ApplicationModule => new Application(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ApplicationPersistenceProfile ApplicationPersistenceProfileModule => new ApplicationPersistenceProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ApplicationProfile ApplicationProfileModule => new ApplicationProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AuthProfile AuthProfileModule => new AuthProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AutoScaleLaunchConfig AutoScaleLaunchConfigModule => new AutoScaleLaunchConfig(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AvailabilityZone AvailabilityZoneModule => new AvailabilityZone(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Backup BackupModule => new Backup(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public BackupConfiguration BackupConfigurationModule => new BackupConfiguration(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public BotConfigConsolidator BotConfigConsolidatorModule => new BotConfigConsolidator(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public BotDetectionPolicy BotDetectionPolicyModule => new BotDetectionPolicy(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public BotIpreputationTypeMapping BotIpreputationTypeMappingModule => new BotIpreputationTypeMapping(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public BotMapping BotMappingModule => new BotMapping(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public CertificateManagementProfile CertificateManagementProfileModule => new CertificateManagementProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Cloud CloudModule => new Cloud(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public CloudConnectorUser CloudConnectorUserModule => new CloudConnectorUser(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public CloudProperties CloudPropertiesModule => new CloudProperties(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public CloudRuntime CloudRuntimeModule => new CloudRuntime(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Cluster ClusterModule => new Cluster(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ClusterCloudDetails ClusterCloudDetailsModule => new ClusterCloudDetails(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ControllerLicense ControllerLicenseModule => new ControllerLicense(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ControllerPortalRegistration ControllerPortalRegistrationModule => new ControllerPortalRegistration(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ControllerProperties ControllerPropertiesModule => new ControllerProperties(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ControllerSite ControllerSiteModule => new ControllerSite(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public CustomerPortalInfo CustomerPortalInfoModule => new CustomerPortalInfo(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public CustomIpamDnsProfile CustomIpamDnsProfileModule => new CustomIpamDnsProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public DebugController DebugControllerModule => new DebugController(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public DebugServiceEngine DebugServiceEngineModule => new DebugServiceEngine(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public DebugVirtualService DebugVirtualServiceModule => new DebugVirtualService(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public DnsPolicy DnsPolicyModule => new DnsPolicy(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public DynamicDnsRecord DynamicDnsRecordModule => new DynamicDnsRecord(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ErrorPageBody ErrorPageBodyModule => new ErrorPageBody(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ErrorPageProfile ErrorPageProfileModule => new ErrorPageProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public FederationCheckpoint FederationCheckpointModule => new FederationCheckpoint(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public FileObject FileObjectModule => new FileObject(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public GeoDB GeoDBModule => new GeoDB(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Gslb GslbModule => new Gslb(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public GslbGeoDbProfile GslbGeoDbProfileModule => new GslbGeoDbProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public GslbService GslbServiceModule => new GslbService(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public HardwareSecurityModuleGroup HardwareSecurityModuleGroupModule => new HardwareSecurityModuleGroup(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public HealthMonitor HealthMonitorModule => new HealthMonitor(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Healthscore HealthscoreModule => new Healthscore(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public HttppolicySet HttppolicySetModule => new HttppolicySet(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public IcapProfile IcapProfileModule => new IcapProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Image ImageModule => new Image(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public InventoryFaultConfig InventoryFaultConfigModule => new InventoryFaultConfig(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public IpAddrGroup IpAddrGroupModule => new IpAddrGroup(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public IpamDnsProviderProfile IpamDnsProviderProfileModule => new IpamDnsProviderProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public IpreputationDB IpreputationDBModule => new IpreputationDB(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public JobEntry JobEntryModule => new JobEntry(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Jwtprofile JwtprofileModule => new Jwtprofile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public JwtserverProfile JwtserverProfileModule => new JwtserverProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public L4PolicySet L4PolicySetModule => new L4PolicySet(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public LabelGroup LabelGroupModule => new LabelGroup(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public LicenseLedgerDetails LicenseLedgerDetailsModule => new LicenseLedgerDetails(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public LicenseStatus LicenseStatusModule => new LicenseStatus(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public LogControllerMapping LogControllerMappingModule => new LogControllerMapping(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public MemoryBalancerRequest MemoryBalancerRequestModule => new MemoryBalancerRequest(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Metrics MetricsModule => new Metrics(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public MicroService MicroServiceModule => new MicroService(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public MicroServiceGroup MicroServiceGroupModule => new MicroServiceGroup(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public NatPolicy NatPolicyModule => new NatPolicy(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Network NetworkModule => new Network(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public NetworkProfile NetworkProfileModule => new NetworkProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public NetworkRuntime NetworkRuntimeModule => new NetworkRuntime(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public NetworkSecurityPolicy NetworkSecurityPolicyModule => new NetworkSecurityPolicy(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public NetworkService NetworkServiceModule => new NetworkService(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public NsxtSegmentRuntime NsxtSegmentRuntimeModule => new NsxtSegmentRuntime(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ObjectAccessPolicy ObjectAccessPolicyModule => new ObjectAccessPolicy(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public PingAccessAgent PingAccessAgentModule => new PingAccessAgent(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Pkiprofile PkiprofileModule => new Pkiprofile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Pool PoolModule => new Pool(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public PoolGroup PoolGroupModule => new PoolGroup(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public PoolGroupDeploymentPolicy PoolGroupDeploymentPolicyModule => new PoolGroupDeploymentPolicy(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public PortalFileUpload PortalFileUploadModule => new PortalFileUpload(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public PriorityLabels PriorityLabelsModule => new PriorityLabels(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ProtocolParser ProtocolParserModule => new ProtocolParser(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Role RoleModule => new Role(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Scheduler SchedulerModule => new Scheduler(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ScpoolServerStateInfo ScpoolServerStateInfoModule => new ScpoolServerStateInfo(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ScvsStateInfo ScvsStateInfoModule => new ScvsStateInfo(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecureChannelAvailableLocalIps SecureChannelAvailableLocalIpsModule => new SecureChannelAvailableLocalIps(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecureChannelMapping SecureChannelMappingModule => new SecureChannelMapping(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecureChannelToken SecureChannelTokenModule => new SecureChannelToken(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecurityManagerData SecurityManagerDataModule => new SecurityManagerData(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecurityPolicy SecurityPolicyModule => new SecurityPolicy(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SeProperties SePropertiesModule => new SeProperties(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ServerAutoScalePolicy ServerAutoScalePolicyModule => new ServerAutoScalePolicy(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ServiceEngine ServiceEngineModule => new ServiceEngine(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ServiceEngineGroup ServiceEngineGroupModule => new ServiceEngineGroup(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ServiceEnginePolicy ServiceEnginePolicyModule => new ServiceEnginePolicy(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SiteVersion SiteVersionModule => new SiteVersion(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SnmpTrapProfile SnmpTrapProfileModule => new SnmpTrapProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SslkeyAndCertificate SslkeyAndCertificateModule => new SslkeyAndCertificate(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Sslprofile SslprofileModule => new Sslprofile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Ssopolicy SsopolicyModule => new Ssopolicy(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public StatediffOperation StatediffOperationModule => new StatediffOperation(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public StatediffSnapshot StatediffSnapshotModule => new StatediffSnapshot(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public StringGroup StringGroupModule => new StringGroup(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SystemConfiguration SystemConfigurationModule => new SystemConfiguration(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SystemLimits SystemLimitsModule => new SystemLimits(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Tenant TenantModule => new Tenant(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public TestSeDatastoreLevel1 TestSeDatastoreLevel1Module => new TestSeDatastoreLevel1(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public TestSeDatastoreLevel2 TestSeDatastoreLevel2Module => new TestSeDatastoreLevel2(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public TestSeDatastoreLevel3 TestSeDatastoreLevel3Module => new TestSeDatastoreLevel3(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public TrafficCloneProfile TrafficCloneProfileModule => new TrafficCloneProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public UpgradeStatusInfo UpgradeStatusInfoModule => new UpgradeStatusInfo(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public UpgradeStatusSummary UpgradeStatusSummaryModule => new UpgradeStatusSummary(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public User UserModule => new User(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public UserAccountProfile UserAccountProfileModule => new UserAccountProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public UserActivity UserActivityModule => new UserActivity(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VcenterServer VcenterServerModule => new VcenterServer(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Vidcinfo VidcinfoModule => new Vidcinfo(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrClusterRuntime VimgrClusterRuntimeModule => new VimgrClusterRuntime(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrControllerRuntime VimgrControllerRuntimeModule => new VimgrControllerRuntime(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrDcruntime VimgrDcruntimeModule => new VimgrDcruntime(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrHostRuntime VimgrHostRuntimeModule => new VimgrHostRuntime(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrNwruntime VimgrNwruntimeModule => new VimgrNwruntime(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrSevmruntime VimgrSevmruntimeModule => new VimgrSevmruntime(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrVcenterRuntime VimgrVcenterRuntimeModule => new VimgrVcenterRuntime(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrVmruntime VimgrVmruntimeModule => new VimgrVmruntime(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VipgnameInfo VipgnameInfoModule => new VipgnameInfo(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VirtualService VirtualServiceModule => new VirtualService(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VrfContext VrfContextModule => new VrfContext(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VsdataScriptSet VsdataScriptSetModule => new VsdataScriptSet(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VsGs VsGsModule => new VsGs(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VsVip VsVipModule => new VsVip(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafApplicationSignatureProvider WafApplicationSignatureProviderModule => new WafApplicationSignatureProvider(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafCRS WafCRSModule => new WafCRS(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafPolicy WafPolicyModule => new WafPolicy(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafPolicyPsmgroup WafPolicyPsmgroupModule => new WafPolicyPsmgroup(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafProfile WafProfileModule => new WafProfile(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Webhook WebhookModule => new Webhook(restClient, sessionCookie, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
    }
}