using System;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using nsxtalbsdk.Modules;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using nsxtalbsdk.Models;
using System.Net;
namespace nsxtalbsdk
{
    public class NSXTALBClient
    {
       public RestClient restClient { get; set; }
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        private string defaultXAviVerion;
        private Cookie sessionCookie;
        private List<Cookie> sessionCookies;
        private string host;
        private int port;
        private bool remoteCertificateValidation;
        private LoginRequestType credentials;
        private Uri uri;
        public NSXTALBClient(string Host, string Username, string Password, bool? RemoteCertificateValidation = true, JsonSerializerSettings? DefaultSerializationSettings = null, CancellationToken _cancellationToken = default(CancellationToken), int Port = 443, int _timeout = 100, int _retry = 2, string _defaultXAviVerion = null)
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
            uri = new UriBuilder(host)
            {
                Scheme = Uri.UriSchemeHttps,
                Port = port
            }.Uri;
            var restOptions = new RestClientOptions() { BaseUrl = uri };
            if (!remoteCertificateValidation) { 
                restOptions.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
            };
            restClient = new RestClient(restOptions);
            if (DefaultSerializationSettings == null)
            {
                restClient.UseNewtonsoftJson(new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    DefaultValueHandling = DefaultValueHandling.Include,
                    TypeNameHandling = TypeNameHandling.None,
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.None,
                    ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
                });
            }
            else
            {
                restClient.UseNewtonsoftJson(DefaultSerializationSettings);
            }
        }
        public async Task<LoginResponseType> LoginAsync()
        {
            RestResponse<LoginResponseType> response = await AuthenticationHelper.LoginAsync(credentials, restClient, cancellationToken, timeout, retry);
            ArgumentNullException.ThrowIfNull(response);
            ArgumentNullException.ThrowIfNull(response.Cookies);
            ArgumentNullException.ThrowIfNull(response.Data);
            sessionCookie = response.Cookies.Single(x => x.Name == response.Data.SessionCookieName);
            sessionCookies = response.Cookies.ToList();
            if (sessionCookie == null)
            {
                throw new NSXTALBException("Cookie variable not found", (int)response.StatusCode, response.Content, response.Headers);
            }
            if (defaultXAviVerion == null)
            {
                defaultXAviVerion = response.Data.Version.MinVersion;
            }
            Cookie csrftoken = sessionCookies.Single(x => x.Name == "csrftoken");
            Cookie sessionid = sessionCookies.Single(x => x.Name == "sessionid");
            restClient.AddCookie("csrftoken", csrftoken.Value, csrftoken.Path, csrftoken.Domain);
            restClient.AddCookie("sessionid", sessionid.Value, sessionid.Path, sessionid.Domain);
            restClient.AddDefaultHeader("X-CSRFToken", csrftoken.Value);
            restClient.AddDefaultHeader("sessionid", sessionid.Value);
            restClient.AddDefaultHeader("Referer", uri.AbsoluteUri);
            return response.Data;
        }
        public async void Logout()
        {
            await AuthenticationHelper.Logout(restClient);
        }
        public ClusterRuntime ClusterRuntimeModule => new ClusterRuntime(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ActionGroupConfig ActionGroupConfigModule => new ActionGroupConfig(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlbservicesConfig AlbservicesConfigModule => new AlbservicesConfig(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlbservicesFileUpload AlbservicesFileUploadModule => new AlbservicesFileUpload(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlbservicesJob AlbservicesJobModule => new AlbservicesJob(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Alert AlertModule => new Alert(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertConfig AlertConfigModule => new AlertConfig(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertEmailConfig AlertEmailConfigModule => new AlertEmailConfig(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertObjectList AlertObjectListModule => new AlertObjectList(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertScriptConfig AlertScriptConfigModule => new AlertScriptConfig(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public AlertSyslogConfig AlertSyslogConfigModule => new AlertSyslogConfig(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public AnalyticsProfile AnalyticsProfileModule => new AnalyticsProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Anomaly AnomalyModule => new Anomaly(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ApiclifsRuntime ApiclifsRuntimeModule => new ApiclifsRuntime(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Application ApplicationModule => new Application(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ApplicationPersistenceProfile ApplicationPersistenceProfileModule => new ApplicationPersistenceProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ApplicationProfile ApplicationProfileModule => new ApplicationProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public AuthProfile AuthProfileModule => new AuthProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public AutoScaleLaunchConfig AutoScaleLaunchConfigModule => new AutoScaleLaunchConfig(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public AvailabilityZone AvailabilityZoneModule => new AvailabilityZone(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Backup BackupModule => new Backup(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public BackupConfiguration BackupConfigurationModule => new BackupConfiguration(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public BotConfigConsolidator BotConfigConsolidatorModule => new BotConfigConsolidator(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public BotDetectionPolicy BotDetectionPolicyModule => new BotDetectionPolicy(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public BotIpreputationTypeMapping BotIpreputationTypeMappingModule => new BotIpreputationTypeMapping(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public BotMapping BotMappingModule => new BotMapping(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public CertificateManagementProfile CertificateManagementProfileModule => new CertificateManagementProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Cloud CloudModule => new Cloud(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public CloudConnectorUser CloudConnectorUserModule => new CloudConnectorUser(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public CloudProperties CloudPropertiesModule => new CloudProperties(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public CloudRuntime CloudRuntimeModule => new CloudRuntime(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Cluster ClusterModule => new Cluster(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ClusterCloudDetails ClusterCloudDetailsModule => new ClusterCloudDetails(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ControllerLicense ControllerLicenseModule => new ControllerLicense(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ControllerPortalRegistration ControllerPortalRegistrationModule => new ControllerPortalRegistration(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ControllerProperties ControllerPropertiesModule => new ControllerProperties(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ControllerSite ControllerSiteModule => new ControllerSite(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public CustomerPortalInfo CustomerPortalInfoModule => new CustomerPortalInfo(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public CustomIpamDnsProfile CustomIpamDnsProfileModule => new CustomIpamDnsProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public DebugController DebugControllerModule => new DebugController(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public DebugServiceEngine DebugServiceEngineModule => new DebugServiceEngine(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public DebugVirtualService DebugVirtualServiceModule => new DebugVirtualService(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public DnsPolicy DnsPolicyModule => new DnsPolicy(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public DynamicDnsRecord DynamicDnsRecordModule => new DynamicDnsRecord(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ErrorPageBody ErrorPageBodyModule => new ErrorPageBody(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ErrorPageProfile ErrorPageProfileModule => new ErrorPageProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public FederationCheckpoint FederationCheckpointModule => new FederationCheckpoint(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public FileObject FileObjectModule => new FileObject(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public GeoDB GeoDBModule => new GeoDB(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Gslb GslbModule => new Gslb(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public GslbGeoDbProfile GslbGeoDbProfileModule => new GslbGeoDbProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public GslbService GslbServiceModule => new GslbService(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public HardwareSecurityModuleGroup HardwareSecurityModuleGroupModule => new HardwareSecurityModuleGroup(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public HealthMonitor HealthMonitorModule => new HealthMonitor(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Healthscore HealthscoreModule => new Healthscore(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public HttppolicySet HttppolicySetModule => new HttppolicySet(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public IcapProfile IcapProfileModule => new IcapProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Image ImageModule => new Image(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public InventoryFaultConfig InventoryFaultConfigModule => new InventoryFaultConfig(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public IpAddrGroup IpAddrGroupModule => new IpAddrGroup(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public IpamDnsProviderProfile IpamDnsProviderProfileModule => new IpamDnsProviderProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public IpreputationDB IpreputationDBModule => new IpreputationDB(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public JobEntry JobEntryModule => new JobEntry(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Jwtprofile JwtprofileModule => new Jwtprofile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public JwtserverProfile JwtserverProfileModule => new JwtserverProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public L4PolicySet L4PolicySetModule => new L4PolicySet(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public LabelGroup LabelGroupModule => new LabelGroup(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public LicenseLedgerDetails LicenseLedgerDetailsModule => new LicenseLedgerDetails(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public LicenseStatus LicenseStatusModule => new LicenseStatus(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public LogControllerMapping LogControllerMappingModule => new LogControllerMapping(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public MemoryBalancerRequest MemoryBalancerRequestModule => new MemoryBalancerRequest(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Metrics MetricsModule => new Metrics(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public MicroService MicroServiceModule => new MicroService(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public MicroServiceGroup MicroServiceGroupModule => new MicroServiceGroup(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public NatPolicy NatPolicyModule => new NatPolicy(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Network NetworkModule => new Network(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public NetworkProfile NetworkProfileModule => new NetworkProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public NetworkRuntime NetworkRuntimeModule => new NetworkRuntime(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public NetworkSecurityPolicy NetworkSecurityPolicyModule => new NetworkSecurityPolicy(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public NetworkService NetworkServiceModule => new NetworkService(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public NsxtSegmentRuntime NsxtSegmentRuntimeModule => new NsxtSegmentRuntime(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ObjectAccessPolicy ObjectAccessPolicyModule => new ObjectAccessPolicy(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public PingAccessAgent PingAccessAgentModule => new PingAccessAgent(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Pkiprofile PkiprofileModule => new Pkiprofile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Pool PoolModule => new Pool(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public PoolGroup PoolGroupModule => new PoolGroup(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public PoolGroupDeploymentPolicy PoolGroupDeploymentPolicyModule => new PoolGroupDeploymentPolicy(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public PortalFileUpload PortalFileUploadModule => new PortalFileUpload(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public PriorityLabels PriorityLabelsModule => new PriorityLabels(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ProtocolParser ProtocolParserModule => new ProtocolParser(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Role RoleModule => new Role(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Scheduler SchedulerModule => new Scheduler(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ScpoolServerStateInfo ScpoolServerStateInfoModule => new ScpoolServerStateInfo(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ScvsStateInfo ScvsStateInfoModule => new ScvsStateInfo(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecureChannelAvailableLocalIps SecureChannelAvailableLocalIpsModule => new SecureChannelAvailableLocalIps(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecureChannelMapping SecureChannelMappingModule => new SecureChannelMapping(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecureChannelToken SecureChannelTokenModule => new SecureChannelToken(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecurityManagerData SecurityManagerDataModule => new SecurityManagerData(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public SecurityPolicy SecurityPolicyModule => new SecurityPolicy(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public SeProperties SePropertiesModule => new SeProperties(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ServerAutoScalePolicy ServerAutoScalePolicyModule => new ServerAutoScalePolicy(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ServiceEngine ServiceEngineModule => new ServiceEngine(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ServiceEngineGroup ServiceEngineGroupModule => new ServiceEngineGroup(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public ServiceEnginePolicy ServiceEnginePolicyModule => new ServiceEnginePolicy(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public SiteVersion SiteVersionModule => new SiteVersion(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public SnmpTrapProfile SnmpTrapProfileModule => new SnmpTrapProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public SslkeyAndCertificate SslkeyAndCertificateModule => new SslkeyAndCertificate(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Sslprofile SslprofileModule => new Sslprofile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Ssopolicy SsopolicyModule => new Ssopolicy(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public StatediffOperation StatediffOperationModule => new StatediffOperation(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public StatediffSnapshot StatediffSnapshotModule => new StatediffSnapshot(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public StringGroup StringGroupModule => new StringGroup(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public SystemConfiguration SystemConfigurationModule => new SystemConfiguration(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public SystemLimits SystemLimitsModule => new SystemLimits(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Tenant TenantModule => new Tenant(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public TestSeDatastoreLevel1 TestSeDatastoreLevel1Module => new TestSeDatastoreLevel1(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public TestSeDatastoreLevel2 TestSeDatastoreLevel2Module => new TestSeDatastoreLevel2(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public TestSeDatastoreLevel3 TestSeDatastoreLevel3Module => new TestSeDatastoreLevel3(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public TrafficCloneProfile TrafficCloneProfileModule => new TrafficCloneProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public UpgradeStatusInfo UpgradeStatusInfoModule => new UpgradeStatusInfo(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public UpgradeStatusSummary UpgradeStatusSummaryModule => new UpgradeStatusSummary(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public User UserModule => new User(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public UserAccountProfile UserAccountProfileModule => new UserAccountProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public UserActivity UserActivityModule => new UserActivity(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VcenterServer VcenterServerModule => new VcenterServer(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Vidcinfo VidcinfoModule => new Vidcinfo(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrClusterRuntime VimgrClusterRuntimeModule => new VimgrClusterRuntime(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrControllerRuntime VimgrControllerRuntimeModule => new VimgrControllerRuntime(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrDcruntime VimgrDcruntimeModule => new VimgrDcruntime(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrHostRuntime VimgrHostRuntimeModule => new VimgrHostRuntime(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrNwruntime VimgrNwruntimeModule => new VimgrNwruntime(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrSevmruntime VimgrSevmruntimeModule => new VimgrSevmruntime(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrVcenterRuntime VimgrVcenterRuntimeModule => new VimgrVcenterRuntime(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VimgrVmruntime VimgrVmruntimeModule => new VimgrVmruntime(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VipgnameInfo VipgnameInfoModule => new VipgnameInfo(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VirtualService VirtualServiceModule => new VirtualService(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VrfContext VrfContextModule => new VrfContext(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VsdataScriptSet VsdataScriptSetModule => new VsdataScriptSet(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VsGs VsGsModule => new VsGs(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public VsVip VsVipModule => new VsVip(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafApplicationSignatureProvider WafApplicationSignatureProviderModule => new WafApplicationSignatureProvider(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafCRS WafCRSModule => new WafCRS(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafPolicy WafPolicyModule => new WafPolicy(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafPolicyPsmgroup WafPolicyPsmgroupModule => new WafPolicyPsmgroup(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public WafProfile WafProfileModule => new WafProfile(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
        public Webhook WebhookModule => new Webhook(restClient, cancellationToken, timeout, retry, defaultXAviVerion);
    }
}