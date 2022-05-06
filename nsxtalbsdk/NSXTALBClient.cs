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
        private string host;
        private int port;
        private bool remoteCertificateValidation;
        private LoginRequestType credentials;
        public NSXTALBClientAsync(string Host, string Username, string Password, bool? RemoteCertificateValidation = true, JsonSerializerSettings? DefaultSerializationSettings = null, CancellationToken _cancellationToken = default(CancellationToken), int Port = 443, int _timeout = 5, int _retry = 2, string _defaultXAviVerion = null)
        {
            host = Host;
            cancellationToken = _cancellationToken;
            timeout = _timeout;
            retry = _retry;
            defaultXAviVerion = _defaultXAviVerion;
            port = Port;
            remoteCertificateValidation = RemoteCertificateValidation ?? true;
            credentials = new LoginRequestType()
            {
                Username = Username,
                Password = Password
            };
            var uri = new UriBuilder(host)
            {
                Scheme = Uri.UriSchemeHttps,
                Port = port
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
        }
        public async Task<LoginResponseType> LoginAsync()
        {
            IRestResponse<LoginResponseType> response = await AuthenticationHelper.LoginAsync(credentials, restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
            sessionCookie = response.Cookies.First(x => x.Name == response.Data.SessionCookieName);
            sessionCookies = response.Cookies.ToList();
            if (sessionCookie == null)
            {
                throw new NSXTALBException("Cookie variable not found", (int)response.StatusCode, response.Content, response.Headers);
            }
            if (defaultXAviVerion == null)
            {
                defaultXAviVerion = response.Data.Version.MinVersion;
            }
            return response.Data;
        }
        public void Logout()
        {
            AuthenticationHelper.Logout(sessionCookies, restClient);
        }
        public ClusterRuntime ClusterRuntimeModule => new ClusterRuntime(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);

        public ActionGroupConfig ActionGroupConfigModule => new ActionGroupConfig(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlbservicesConfig AlbservicesConfigModule => new AlbservicesConfig(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlbservicesFileUpload AlbservicesFileUploadModule => new AlbservicesFileUpload(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlbservicesJob AlbservicesJobModule => new AlbservicesJob(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Alert AlertModule => new Alert(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertConfig AlertConfigModule => new AlertConfig(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertEmailConfig AlertEmailConfigModule => new AlertEmailConfig(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertObjectList AlertObjectListModule => new AlertObjectList(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertScriptConfig AlertScriptConfigModule => new AlertScriptConfig(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertSyslogConfig AlertSyslogConfigModule => new AlertSyslogConfig(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AnalyticsProfile AnalyticsProfileModule => new AnalyticsProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Anomaly AnomalyModule => new Anomaly(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ApiclifsRuntime ApiclifsRuntimeModule => new ApiclifsRuntime(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Application ApplicationModule => new Application(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ApplicationPersistenceProfile ApplicationPersistenceProfileModule => new ApplicationPersistenceProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ApplicationProfile ApplicationProfileModule => new ApplicationProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AuthProfile AuthProfileModule => new AuthProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AutoScaleLaunchConfig AutoScaleLaunchConfigModule => new AutoScaleLaunchConfig(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public AvailabilityZone AvailabilityZoneModule => new AvailabilityZone(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Backup BackupModule => new Backup(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public BackupConfiguration BackupConfigurationModule => new BackupConfiguration(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public BotConfigConsolidator BotConfigConsolidatorModule => new BotConfigConsolidator(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public BotDetectionPolicy BotDetectionPolicyModule => new BotDetectionPolicy(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public BotIpreputationTypeMapping BotIpreputationTypeMappingModule => new BotIpreputationTypeMapping(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public BotMapping BotMappingModule => new BotMapping(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public CertificateManagementProfile CertificateManagementProfileModule => new CertificateManagementProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Cloud CloudModule => new Cloud(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public CloudConnectorUser CloudConnectorUserModule => new CloudConnectorUser(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public CloudProperties CloudPropertiesModule => new CloudProperties(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public CloudRuntime CloudRuntimeModule => new CloudRuntime(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Cluster ClusterModule => new Cluster(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ClusterCloudDetails ClusterCloudDetailsModule => new ClusterCloudDetails(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ControllerLicense ControllerLicenseModule => new ControllerLicense(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ControllerPortalRegistration ControllerPortalRegistrationModule => new ControllerPortalRegistration(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ControllerProperties ControllerPropertiesModule => new ControllerProperties(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ControllerSite ControllerSiteModule => new ControllerSite(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public CustomerPortalInfo CustomerPortalInfoModule => new CustomerPortalInfo(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public CustomIpamDnsProfile CustomIpamDnsProfileModule => new CustomIpamDnsProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public DebugController DebugControllerModule => new DebugController(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public DebugServiceEngine DebugServiceEngineModule => new DebugServiceEngine(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public DebugVirtualService DebugVirtualServiceModule => new DebugVirtualService(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public DnsPolicy DnsPolicyModule => new DnsPolicy(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public DynamicDnsRecord DynamicDnsRecordModule => new DynamicDnsRecord(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ErrorPageBody ErrorPageBodyModule => new ErrorPageBody(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ErrorPageProfile ErrorPageProfileModule => new ErrorPageProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public FederationCheckpoint FederationCheckpointModule => new FederationCheckpoint(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public FileObject FileObjectModule => new FileObject(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public GeoDB GeoDBModule => new GeoDB(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Gslb GslbModule => new Gslb(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public GslbGeoDbProfile GslbGeoDbProfileModule => new GslbGeoDbProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public GslbService GslbServiceModule => new GslbService(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public HardwareSecurityModuleGroup HardwareSecurityModuleGroupModule => new HardwareSecurityModuleGroup(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public HealthMonitor HealthMonitorModule => new HealthMonitor(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Healthscore HealthscoreModule => new Healthscore(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public HttppolicySet HttppolicySetModule => new HttppolicySet(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public IcapProfile IcapProfileModule => new IcapProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Image ImageModule => new Image(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public InventoryFaultConfig InventoryFaultConfigModule => new InventoryFaultConfig(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public IpAddrGroup IpAddrGroupModule => new IpAddrGroup(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public IpamDnsProviderProfile IpamDnsProviderProfileModule => new IpamDnsProviderProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public IpreputationDB IpreputationDBModule => new IpreputationDB(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public JobEntry JobEntryModule => new JobEntry(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Jwtprofile JwtprofileModule => new Jwtprofile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public JwtserverProfile JwtserverProfileModule => new JwtserverProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public L4PolicySet L4PolicySetModule => new L4PolicySet(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public LabelGroup LabelGroupModule => new LabelGroup(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public LicenseLedgerDetails LicenseLedgerDetailsModule => new LicenseLedgerDetails(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public LicenseStatus LicenseStatusModule => new LicenseStatus(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public LogControllerMapping LogControllerMappingModule => new LogControllerMapping(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public MemoryBalancerRequest MemoryBalancerRequestModule => new MemoryBalancerRequest(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Metrics MetricsModule => new Metrics(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public MicroService MicroServiceModule => new MicroService(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public MicroServiceGroup MicroServiceGroupModule => new MicroServiceGroup(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public NatPolicy NatPolicyModule => new NatPolicy(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Network NetworkModule => new Network(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public NetworkProfile NetworkProfileModule => new NetworkProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public NetworkRuntime NetworkRuntimeModule => new NetworkRuntime(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public NetworkSecurityPolicy NetworkSecurityPolicyModule => new NetworkSecurityPolicy(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public NetworkService NetworkServiceModule => new NetworkService(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public NsxtSegmentRuntime NsxtSegmentRuntimeModule => new NsxtSegmentRuntime(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ObjectAccessPolicy ObjectAccessPolicyModule => new ObjectAccessPolicy(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public PingAccessAgent PingAccessAgentModule => new PingAccessAgent(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Pkiprofile PkiprofileModule => new Pkiprofile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Pool PoolModule => new Pool(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public PoolGroup PoolGroupModule => new PoolGroup(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public PoolGroupDeploymentPolicy PoolGroupDeploymentPolicyModule => new PoolGroupDeploymentPolicy(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public PortalFileUpload PortalFileUploadModule => new PortalFileUpload(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public PriorityLabels PriorityLabelsModule => new PriorityLabels(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ProtocolParser ProtocolParserModule => new ProtocolParser(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Role RoleModule => new Role(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Scheduler SchedulerModule => new Scheduler(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ScpoolServerStateInfo ScpoolServerStateInfoModule => new ScpoolServerStateInfo(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ScvsStateInfo ScvsStateInfoModule => new ScvsStateInfo(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecureChannelAvailableLocalIps SecureChannelAvailableLocalIpsModule => new SecureChannelAvailableLocalIps(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecureChannelMapping SecureChannelMappingModule => new SecureChannelMapping(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecureChannelToken SecureChannelTokenModule => new SecureChannelToken(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecurityManagerData SecurityManagerDataModule => new SecurityManagerData(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecurityPolicy SecurityPolicyModule => new SecurityPolicy(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SeProperties SePropertiesModule => new SeProperties(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ServerAutoScalePolicy ServerAutoScalePolicyModule => new ServerAutoScalePolicy(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ServiceEngine ServiceEngineModule => new ServiceEngine(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ServiceEngineGroup ServiceEngineGroupModule => new ServiceEngineGroup(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public ServiceEnginePolicy ServiceEnginePolicyModule => new ServiceEnginePolicy(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SiteVersion SiteVersionModule => new SiteVersion(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SnmpTrapProfile SnmpTrapProfileModule => new SnmpTrapProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SslkeyAndCertificate SslkeyAndCertificateModule => new SslkeyAndCertificate(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Sslprofile SslprofileModule => new Sslprofile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Ssopolicy SsopolicyModule => new Ssopolicy(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public StatediffOperation StatediffOperationModule => new StatediffOperation(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public StatediffSnapshot StatediffSnapshotModule => new StatediffSnapshot(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public StringGroup StringGroupModule => new StringGroup(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SystemConfiguration SystemConfigurationModule => new SystemConfiguration(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public SystemLimits SystemLimitsModule => new SystemLimits(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Tenant TenantModule => new Tenant(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public TestSeDatastoreLevel1 TestSeDatastoreLevel1Module => new TestSeDatastoreLevel1(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public TestSeDatastoreLevel2 TestSeDatastoreLevel2Module => new TestSeDatastoreLevel2(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public TestSeDatastoreLevel3 TestSeDatastoreLevel3Module => new TestSeDatastoreLevel3(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public TrafficCloneProfile TrafficCloneProfileModule => new TrafficCloneProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public UpgradeStatusInfo UpgradeStatusInfoModule => new UpgradeStatusInfo(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public UpgradeStatusSummary UpgradeStatusSummaryModule => new UpgradeStatusSummary(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public User UserModule => new User(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public UserAccountProfile UserAccountProfileModule => new UserAccountProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public UserActivity UserActivityModule => new UserActivity(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VcenterServer VcenterServerModule => new VcenterServer(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Vidcinfo VidcinfoModule => new Vidcinfo(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrClusterRuntime VimgrClusterRuntimeModule => new VimgrClusterRuntime(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrControllerRuntime VimgrControllerRuntimeModule => new VimgrControllerRuntime(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrDcruntime VimgrDcruntimeModule => new VimgrDcruntime(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrHostRuntime VimgrHostRuntimeModule => new VimgrHostRuntime(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrNwruntime VimgrNwruntimeModule => new VimgrNwruntime(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrSevmruntime VimgrSevmruntimeModule => new VimgrSevmruntime(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrVcenterRuntime VimgrVcenterRuntimeModule => new VimgrVcenterRuntime(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrVmruntime VimgrVmruntimeModule => new VimgrVmruntime(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VipgnameInfo VipgnameInfoModule => new VipgnameInfo(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VirtualService VirtualServiceModule => new VirtualService(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VrfContext VrfContextModule => new VrfContext(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VsdataScriptSet VsdataScriptSetModule => new VsdataScriptSet(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VsGs VsGsModule => new VsGs(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public VsVip VsVipModule => new VsVip(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafApplicationSignatureProvider WafApplicationSignatureProviderModule => new WafApplicationSignatureProvider(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafCRS WafCRSModule => new WafCRS(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafPolicy WafPolicyModule => new WafPolicy(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafPolicyPsmgroup WafPolicyPsmgroupModule => new WafPolicyPsmgroup(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafProfile WafProfileModule => new WafProfile(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
        public Webhook WebhookModule => new Webhook(restClient, sessionCookies, defaultSerializationSettings, cancellationToken, timeout, retry, defaultXAviVerion);
    }
}