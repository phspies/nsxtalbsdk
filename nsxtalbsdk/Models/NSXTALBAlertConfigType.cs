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
    public class NSXTALBAlertConfigType 
    {
        public NSXTALBAlertConfigType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// The alert config will trigger the selected alert action, which can send notifications and execute a controlscript. It is
        /// a reference to an object of type ActionGroupConfig.
        /// </summary>
        [JsonProperty(PropertyName = "action_group_ref")]
        public string? ActionGroupRef { get; set; }
        /// <summary>
        /// list of filters matching on events or client logs used for triggering alerts.
        /// </summary>
        [JsonProperty(PropertyName = "alert_rule", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBAlertRuleType AlertRule { get; set; }
        /// <summary>
        /// This alert config applies to auto scale alerts.
        /// </summary>
        [JsonProperty(PropertyName = "autoscale_alert")]
        public bool? AutoscaleAlert { get; set; }
        /// <summary>
        /// Determines whether an alert is raised immediately when event occurs (realtime) or after specified number of events
        /// occurs within rolling time window. Enum options - REALTIME, ROLLINGWINDOW, WATERMARK.
        /// </summary>
        [JsonProperty(PropertyName = "category", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Category { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// A custom description field.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Enable or disable this alert config from generating new alerts.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// An alert is expired and deleted after the expiry time has elapsed.  The original event triggering the alert remains in
        /// the event's log. Allowed values are 1-31536000. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "expiry_time")]
        public int? ExpiryTime { get; set; }
        /// <summary>
        /// Name of the alert configuration.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// UUID of the resource for which alert was raised.
        /// </summary>
        [JsonProperty(PropertyName = "obj_uuid")]
        public string? ObjUuid { get; set; }
        /// <summary>
        /// The object type to which the Alert Config is associated with. Valid object types are - Virtual Service, Pool, Service
        /// Engine. Enum options - VIRTUALSERVICE, POOL, HEALTHMONITOR, NETWORKPROFILE, APPLICATIONPROFILE, HTTPPOLICYSET,
        /// DNSPOLICY, SECURITYPOLICY, IPADDRGROUP, STRINGGROUP, SSLPROFILE, SSLKEYANDCERTIFICATE, NETWORKSECURITYPOLICY,
        /// APPLICATIONPERSISTENCEPROFILE, ANALYTICSPROFILE, VSDATASCRIPTSET, TENANT, PKIPROFILE, AUTHPROFILE, CLOUD,
        /// SERVERAUTOSCALEPOLICY, AUTOSCALELAUNCHCONFIG, MICROSERVICEGROUP, IPAMPROFILE, HARDWARESECURITYMODULEGROUP, POOLGROUP,
        /// PRIORITYLABELS, POOLGROUPDEPLOYMENTPOLICY, GSLBSERVICE, GSLBSERVICERUNTIME, SCHEDULER, GSLBGEODBPROFILE,
        /// GSLBAPPLICATIONPERSISTENCEPROFILE, TRAFFICCLONEPROFILE, VSVIP, WAFPOLICY, WAFPROFILE, ERRORPAGEPROFILE, ERRORPAGEBODY,
        /// L4POLICYSET, GSLBSERVICERUNTIMEBATCH, WAFPOLICYPSMGROUP, PINGACCESSAGENT, NETWORKSERVICE, NATPOLICY, SSOPOLICY,
        /// PROTOCOLPARSER, EXAMPLECHILD, TESTSEDATASTORELEVEL1, TESTSEDATASTORELEVEL2, TESTSEDATASTORELEVEL3, FILEOBJECT,
        /// IPREPUTATIONDB, FEDERATIONCHECKPOINT, ICAPPROFILE, DYNAMICDNSRECORD, JWTSERVERPROFILE, GEODB, BOTDETECTIONPOLICY,
        /// BOTMAPPING, BOTCONFIGCONSOLIDATOR, JWTPROFILE, BOTIPREPUTATIONTYPEMAPPING, AVIFALSEPOSITIVEDETECTION, VSGS, WAFCRS,
        /// SERVICEENGINE, DEBUGSERVICEENGINE, DEBUGCONTROLLER, DEBUGVIRTUALSERVICE, SERVICEENGINEGROUP, SEPROPERTIES, NETWORK,
        /// CONTROLLERNODE, CONTROLLERPROPERTIES, SYSTEMCONFIGURATION, VRFCONTEXT, USER, ALERTCONFIG, ALERTSYSLOGCONFIG,
        /// ALERTEMAILCONFIG, ALERTTYPECONFIG, APPLICATION, ROLE, CLOUDPROPERTIES, SNMPTRAPPROFILE, ACTIONGROUPPROFILE,
        /// MICROSERVICE, ALERTPARAMS, ACTIONGROUPCONFIG, CLOUDCONNECTORUSER, GSLB, GSLBDNSUPDATE, GSLBSITEOPS, GLBMGRWARMSTART,
        /// IPAMDNSRECORD, GSLBDNSGSSTATUS, GSLBDNSGEOFILEOPS, GSLBDNSGEOUPDATE, GSLBDNSGEOCLUSTEROPS, GSLBDNSCLEANUP,
        /// GSLBSITEOPSRESYNC, IPAMDNSPROVIDERPROFILE, ALBSERVICESCONFIG, SYSTEMLIMITS, REPLICATIONOPERATION, VCENTERSERVER,
        /// AVAILABILITYZONE, IMAGE, VSMGRDNSCLEANUP, ALBSERVICESFILEUPLOAD, CONTROLLERSITE, ALERTOBJECTLIST, BACKUPCONFIGURATION,
        /// USERACCOUNTPROFILE, WAFAPPLICATIONSIGNATUREPROVIDER, LABELGROUP, CERTIFICATEMANAGEMENTPROFILE, CUSTOMIPAMDNSPROFILE,
        /// ALERTSCRIPTCONFIG, WEBHOOK, CLUSTERCLOUDDETAILS, INVENTORYFAULTCONFIG, MEMORYBALANCERREQUEST, SECURECHANNELMAPPING,
        /// ALBSERVICESJOB, STATEDIFFOPERATION, TCPSTATRUNTIME, UDPSTATRUNTIME, IPSTATRUNTIME, ARPSTATRUNTIME, MBSTATRUNTIME,
        /// IPSTKQSTATSRUNTIME, MALLOCSTATRUNTIME, SHMALLOCSTATRUNTIME, CPUUSAGERUNTIME, L7GLOBALSTATSRUNTIME,
        /// L7VIRTUALSERVICESTATSRUNTIME, SEAGENTVNICDBRUNTIME, SEAGENTGRAPHDBRUNTIME, SEAGENTSTATERUNTIME, INTERFACERUNTIME,
        /// ARPTABLERUNTIME, DISPATCHERSTATRUNTIME, DISPATCHERSTATCLEARRUNTIME, DISPATCHERTABLEDUMPRUNTIME,
        /// DISPATCHERREMOTETIMERLISTDUMPRUNTIME, METRICSAGENTMESSAGE, HEALTHMONITORSTATRUNTIME, METRICSENTITYRUNTIME,
        /// PERSISTENCEINTERNAL, HTTPPOLICYSETINTERNAL, DNSPOLICYINTERNAL, CONNECTIONDUMPRUNTIME, SHAREDDBSTATS, SHAREDDBSTATSCLEAR,
        /// ICMPSTATRUNTIME, ROUTETABLERUNTIME, VIRTUALMACHINE, POOLSERVER, SEVSLIST, MEMINFORUNTIME, RTERINGSTATRUNTIME,
        /// ALGOSTATRUNTIME, HEALTHMONITORRUNTIME, CPUSTATRUNTIME, SEVM, HOST, PORTGROUP, CLUSTER, DATACENTER, VCENTER,
        /// HTTPPOLICYSETSTATS, DNSPOLICYSTATS, METRICSSESTATS, RATELIMITERSTATRUNTIME, NETWORKSECURITYPOLICYSTATS, TCPCONNRUNTIME,
        /// POOLSTATS, CONNPOOLINTERNAL, CONNPOOLSTATS, VSHASHSHOWRUNTIME, SELOGSTATSRUNTIME, NETWORKSECURITYPOLICYDETAIL,
        /// LICENSERUNTIME, SERVERRUNTIME, METRICSRUNTIMESUMMARY, METRICSRUNTIMEDETAIL, DISPATCHERSEHMPROBETEMPDISABLERUNTIME,
        /// POOLDEBUG, VSLOGMGRMAP, SERUMINSERTIONSTATS, HTTPCACHE, HTTPCACHESTATS, SEDOSSTATRUNTIME, VSDOSSTATRUNTIME,
        /// SERVERUPDATEREQ, VSSCALEOUTLIST, SEMEMDISTRUNTIME, TCPCONNRUNTIMEDETAIL, SEUPGRADESTATUS, SEUPGRADEPREVIEW,
        /// SEFAULTINJECTEXHAUSTM, SEFAULTINJECTEXHAUSTMCL, SEFAULTINJECTEXHAUSTMCLSMALL, SEFAULTINJECTEXHAUSTCONN,
        /// SEHEADLESSONLINEREQ, SEUPGRADE, SEUPGRADESTATUSDETAIL, SERESERVEDVS, SERESERVEDVSCLEAR, VSCANDIDATESEHOSTLIST,
        /// SEGROUPUPGRADE, REBALANCE, SEGROUPREBALANCE, SEAUTHSTATSRUNTIME, AUTOSCALESTATE, VIRTUALSERVICEAUTHSTATS,
        /// NETWORKSECURITYPOLICYDOS, KEYVALINTERNAL, KEYVALSUMMARYINTERNAL, SERVERSTATEUPDATEINFO, CLTRACKINTERNAL,
        /// CLTRACKSUMMARYINTERNAL, MICROSERVICERUNTIME, SEMICROSERVICE, VIRTUALSERVICEANALYSIS, CLIENTINTERNAL,
        /// CLIENTSUMMARYINTERNAL, MICROSERVICEGROUPRUNTIME, BGPRUNTIME, REQUESTQUEUERUNTIME, MIGRATEALL, MIGRATEALLSTATUSSUMMARY,
        /// MIGRATEALLSTATUSDETAIL, INTERFACESUMMARYRUNTIME, INTERFACELACPRUNTIME, DNSTABLE, GSLBSERVICEDETAIL, GSLBSERVICEINTERNAL,
        /// GSLBSERVICEHMONSTAT, SETROLESREQUEST, TRAFFICCLONERUNTIME, GEOLOCATIONINFO, SEVSHBSTATRUNTIME, GEODBINTERNAL,
        /// GSLBSITEINTERNAL, WAFSTATS, USERDEFINEDDATASCRIPTCOUNTERS, LLDPRUNTIME, VSESSHARINGPOOL, NDTABLERUNTIME, IP6STATRUNTIME,
        /// ICMP6STATRUNTIME, SEVSSPLACEMENT, L4POLICYSETSTATS, L4POLICYSETINTERNAL, BGPDEBUGINFO, SHARD, CPUSTATRUNTIMEDETAIL,
        /// SEASSERTSTATRUNTIME, SEFAULTINJECTINFRA, SEAGENTASSERTSTATRUNTIME, SEDATASTORESTATUS, DIFFQUEUESTATUS,
        /// IP6ROUTETABLERUNTIME, SECURITYMGRSTATE, VIRTUALSERVICESESCALEOUTSTATUS, SHARDSERVERSTATUS,
        /// SEAGENTSHARDCLIENTRESOURCEMAP, SEAGENTCONSISTENTHASH, SEAGENTVNICDBHISTORY, SEAGENTSHARDCLIENTAPPMAP,
        /// SEAGENTSHARDCLIENTEVENTHISTORY, NATSTATRUNTIME, NATFLOWRUNTIME, SECUTIRYMGRRUNTIME, SSOPOLICYSTATS,
        /// SENETWORKSERVICERUNTIME, SEGEORUNTIME, NATPOLICYSTATS, SEFAULTRUNTIME, VIRTUALSERVICESCALEOUTSTATUS,
        /// VIRTUALSERVICESCALEOUTSTATUSDETAIL, SECURITYMGRLEARN, SECURITYMGRTOPN, SSLSESSIONCACHE, SEGEODETAILS,
        /// GSLBSERVICEALGOSTAT, HTTPCONNECTIONRUNTIME, HTTPCONNECTIONRUNTIMEDETAIL, REMOTESITEWATCHERSUMMARY,
        /// REMOTESITEWATCHEREVENT, IPREPUTATIONDBRUNTIME, SEFAULTINJECTEXHAUSTCFG, SEFAULTINJECTEXHAUSTSHMCFG,
        /// SEFAULTINJECTEXHAUSTSHMCONN, BGPRUNNINGCONFIG, BGPADVERTISEDROUTES, BGPPEERSTATUS, BFDSESSIONSTATUS, BGPPEERINFO,
        /// GSLBSITEOPSREPLICATIONPOLICYOPS, FEDERATEDDATASTORESTATUS, FEDERATEDDIFFQUEUESTATUS, ROUTESTATRUNTIME, ROUTEFLOWRUNTIME,
        /// NSXTSEGMENTRUNTIME, VIRTUALSERVICEICAPSTATS, KEYVALSUMMARYOBJSYNC, POOLOBJSYNC, KEYVALDISPATCH, SEAGENTOBJSYNCDETAILS,
        /// VIRTUALSERVICESCALEOUTSTATUSKEYVAL, VIRTUALSERVICESCALEOUTSTATUSKEYVALSUMMARY, VIRTUALSERVICEOUTOFBANDREQUESTSTATS,
        /// GEODBLOCATIONINFO, SEAGENTRESOLVDBRUNTIME, SEAGENTRESOLVDBRUNTIMESUMMARY, METRICSRUNTIMEDEBUG,
        /// BOTCLASSIFICATIONRESULTMETRICS, BOTUACACHERUNTIME, BOTUACACHESTATSRUNTIME, POOLGROUPRUNTIMEDETAIL,
        /// SECURITYMGRUACACHEQUERY, SECURITYMGRUACACHECLEAR, SECURITYMGRUACACHESUMMARY, GSLBADAPTIVERUNTIME, BGPPEERSSTATE,
        /// VSSERVICESERVERMAPKV, VSSERVICESERVERMAPTABLE, UPGRADESTATUSINFO, CLOUDRUNTIME, SERESOURCEPROTO, SECONSUMERPROTO,
        /// SECREATEPENDINGPROTO, PLACEMENTSTATS, SEVIPPROTO, RMVRFPROTO, VCENTERMAP, VIMGRVCENTERRUNTIME, INTERESTEDVMS,
        /// INTERESTEDHOSTS, VCENTERSUPPORTEDCOUNTERS, ENTITYCOUNTERS, TRANSACTIONSTATS, SEVMCREATEPROGRESS, PLACEMENTSTATUS,
        /// VISUBFOLDERS, VIDATASTORE, VIHOSTRESOURCES, CLOUDCONNECTOR, VINETWORKSUBNETVMS, VIDATASTORECONTENTS,
        /// VIMGRVCENTERCLOUDRUNTIME, VIVCENTERPORTGROUPS, VIVCENTERDATACENTERS, VIMGRHOSTRUNTIME, PLACEMENTGLOBALS, ALBSERVICES,
        /// RMCLOUDOPSPROTO, CLOUDPLACEMENTSUMMARY, CLOUDPLACEMENTINELIGIBLE, SEGROUPPLACEMENTSUMMARY, SEGROUPPLACEMENTDETAIL,
        /// SEGROUPPLACEMENTINELIGIBLE, SECONSUMERSUMMARY, SECONSUMERDETAIL, SERESOURCESUMMARY, SERESOURCEDETAIL,
        /// PLACEMENTSYSTEMSUMMARY, VIMGRNWRUNTIME, NETWORKRUNTIME, APICCONFIGURATION, CIFTABLE, APICTRANSACTION,
        /// VIRTUALSERVICESTATEDBCACHESUMMARY, POOLSTATEDBCACHESUMMARY, SERVERSTATEDBCACHESUMMARY, APICAGENTINTERNAL,
        /// APICTRANSACTIONFLAP, APICGRAPHINSTANCES, APICEPGS, APICEPGEPS, APICDEVICEPKGVER, APICTENANTS, APICVMMDOMAINS,
        /// STATECACHESTATS, STATECACHECONFIG, STATECACHEINTERNAL, STATECACHEDNS, STATECACHECONFIGVERSION, NSXCONFIGURATION,
        /// NSXSGTABLE, NSXAGENTINTERNAL, NSXSGINFO, NSXSGIPS, NSXAGENTINTERNALCLI, NSXTAGENT, SERATELIMITINGRLINTERNAL,
        /// SERATELIMITINGMSFINTERNAL, ADAPTREPL, POOLGROUPENABLEPRIMARYPOOL, MAXOBJECTS.
        /// </summary>
        [JsonProperty(PropertyName = "object_type")]
        public string? ObjectType { get; set; }
        /// <summary>
        /// recommendation of AlertConfig.
        /// </summary>
        [JsonProperty(PropertyName = "recommendation")]
        public string? Recommendation { get; set; }
        /// <summary>
        /// Only if the Number of Events is reached or exceeded within the Time Window will an alert be generated. Allowed values
        /// are 1-31536000. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "rolling_window")]
        public int? RollingWindow { get; set; }
        /// <summary>
        /// Signifies system events or the type of client logsused in this alert configuration. Enum options - CONN_LOGS, APP_LOGS,
        /// EVENT_LOGS, METRICS.
        /// </summary>
        [JsonProperty(PropertyName = "source", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Source { get; set; }
        /// <summary>
        /// Summary of reason why alert is generated.
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string? Summary { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// An alert is created only when the number of events meets or exceeds this number within the chosen time frame. Allowed
        /// values are 1-65536.
        /// </summary>
        [JsonProperty(PropertyName = "threshold")]
        public int? Threshold { get; set; }
        /// <summary>
        /// Alerts are suppressed (throttled) for this duration of time since the last alert was raised for this alert config.
        /// Allowed values are 0-31536000. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "throttle")]
        public int? Throttle { get; set; }
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
    }
}
