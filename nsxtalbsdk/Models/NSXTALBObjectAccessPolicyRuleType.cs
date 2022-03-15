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
    public class NSXTALBObjectAccessPolicyRuleType 
    {
        /// <summary>
        /// Match criteria for the rule. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "matches")]
        public IList<NSXTALBObjectAccessMatchTargetType> Matches { get; set; }
        /// <summary>
        /// Name of the rule. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Object types that this rule applies to. Enum options - VIRTUALSERVICE, POOL, HEALTHMONITOR, NETWORKPROFILE,
        /// APPLICATIONPROFILE, HTTPPOLICYSET, DNSPOLICY, SECURITYPOLICY, IPADDRGROUP, STRINGGROUP, SSLPROFILE,
        /// SSLKEYANDCERTIFICATE, NETWORKSECURITYPOLICY, APPLICATIONPERSISTENCEPROFILE, ANALYTICSPROFILE, VSDATASCRIPTSET, TENANT,
        /// PKIPROFILE, AUTHPROFILE, CLOUD, SERVERAUTOSCALEPOLICY, AUTOSCALELAUNCHCONFIG, MICROSERVICEGROUP, IPAMPROFILE,
        /// HARDWARESECURITYMODULEGROUP, POOLGROUP, PRIORITYLABELS, POOLGROUPDEPLOYMENTPOLICY, GSLBSERVICE, GSLBSERVICERUNTIME,
        /// SCHEDULER, GSLBGEODBPROFILE, GSLBAPPLICATIONPERSISTENCEPROFILE, TRAFFICCLONEPROFILE, VSVIP, WAFPOLICY, WAFPROFILE,
        /// ERRORPAGEPROFILE, ERRORPAGEBODY, L4POLICYSET, GSLBSERVICERUNTIMEBATCH, WAFPOLICYPSMGROUP, PINGACCESSAGENT,
        /// NETWORKSERVICE, NATPOLICY, SSOPOLICY, PROTOCOLPARSER, EXAMPLECHILD, TESTSEDATASTORELEVEL1, TESTSEDATASTORELEVEL2,
        /// TESTSEDATASTORELEVEL3, FILEOBJECT, IPREPUTATIONDB, FEDERATIONCHECKPOINT, SERVICEENGINE, DEBUGSERVICEENGINE,
        /// DEBUGCONTROLLER, DEBUGVIRTUALSERVICE, SERVICEENGINEGROUP, SEPROPERTIES, NETWORK, CONTROLLERNODE, CONTROLLERPROPERTIES,
        /// SYSTEMCONFIGURATION, VRFCONTEXT, USER, ALERTCONFIG, ALERTSYSLOGCONFIG, ALERTEMAILCONFIG, ALERTTYPECONFIG, APPLICATION,
        /// ROLE, CLOUDPROPERTIES, SNMPTRAPPROFILE, ACTIONGROUPPROFILE, MICROSERVICE, ALERTPARAMS, ACTIONGROUPCONFIG,
        /// CLOUDCONNECTORUSER, GSLB, GSLBDNSUPDATE, GSLBSITEOPS, GLBMGRWARMSTART, IPAMDNSRECORD, GSLBDNSGSSTATUS,
        /// GSLBDNSGEOFILEOPS, GSLBDNSGEOUPDATE, GSLBDNSGEOCLUSTEROPS, GSLBDNSCLEANUP, GSLBSITEOPSRESYNC, IPAMDNSPROVIDERPROFILE,
        /// ALBSERVICESCONFIG, SYSTEMLIMITS, REPLICATIONOPERATION, VCENTERSERVER, AVAILABILITYZONE, TCPSTATRUNTIME, UDPSTATRUNTIME,
        /// IPSTATRUNTIME, ARPSTATRUNTIME, MBSTATRUNTIME, IPSTKQSTATSRUNTIME, MALLOCSTATRUNTIME, SHMALLOCSTATRUNTIME,
        /// CPUUSAGERUNTIME, L7GLOBALSTATSRUNTIME, L7VIRTUALSERVICESTATSRUNTIME, SEAGENTVNICDBRUNTIME, SEAGENTGRAPHDBRUNTIME,
        /// SEAGENTSTATERUNTIME, INTERFACERUNTIME, ARPTABLERUNTIME, DISPATCHERSTATRUNTIME, DISPATCHERSTATCLEARRUNTIME,
        /// DISPATCHERTABLEDUMPRUNTIME, DISPATCHERREMOTETIMERLISTDUMPRUNTIME, METRICSAGENTMESSAGE, HEALTHMONITORSTATRUNTIME,
        /// METRICSENTITYRUNTIME, PERSISTENCEINTERNAL, HTTPPOLICYSETINTERNAL, DNSPOLICYINTERNAL, CONNECTIONDUMPRUNTIME,
        /// SHAREDDBSTATS, SHAREDDBSTATSCLEAR, ICMPSTATRUNTIME, ROUTETABLERUNTIME, VIRTUALMACHINE, POOLSERVER, SEVSLIST,
        /// MEMINFORUNTIME, RTERINGSTATRUNTIME, ALGOSTATRUNTIME, HEALTHMONITORRUNTIME, CPUSTATRUNTIME, SEVM, HOST, PORTGROUP,
        /// CLUSTER, DATACENTER, VCENTER, HTTPPOLICYSETSTATS, DNSPOLICYSTATS, METRICSSESTATS, RATELIMITERSTATRUNTIME,
        /// NETWORKSECURITYPOLICYSTATS, TCPCONNRUNTIME, POOLSTATS, CONNPOOLINTERNAL, CONNPOOLSTATS, VSHASHSHOWRUNTIME,
        /// SELOGSTATSRUNTIME, NETWORKSECURITYPOLICYDETAIL, LICENSERUNTIME, SERVERRUNTIME, METRICSRUNTIMESUMMARY,
        /// METRICSRUNTIMEDETAIL, DISPATCHERSEHMPROBETEMPDISABLERUNTIME, POOLDEBUG, VSLOGMGRMAP, SERUMINSERTIONSTATS, HTTPCACHE,
        /// HTTPCACHESTATS, SEDOSSTATRUNTIME, VSDOSSTATRUNTIME, SERVERUPDATEREQ, VSSCALEOUTLIST, SEMEMDISTRUNTIME,
        /// TCPCONNRUNTIMEDETAIL, SEUPGRADESTATUS, SEUPGRADEPREVIEW, SEFAULTINJECTEXHAUSTM, SEFAULTINJECTEXHAUSTMCL,
        /// SEFAULTINJECTEXHAUSTMCLSMALL, SEFAULTINJECTEXHAUSTCONN, SEHEADLESSONLINEREQ, SEUPGRADE, SEUPGRADESTATUSDETAIL,
        /// SERESERVEDVS, SERESERVEDVSCLEAR, VSCANDIDATESEHOSTLIST, SEGROUPUPGRADE, REBALANCE, SEGROUPREBALANCE, SEAUTHSTATSRUNTIME,
        /// AUTOSCALESTATE, VIRTUALSERVICEAUTHSTATS, NETWORKSECURITYPOLICYDOS, KEYVALINTERNAL, KEYVALSUMMARYINTERNAL,
        /// SERVERSTATEUPDATEINFO, CLTRACKINTERNAL, CLTRACKSUMMARYINTERNAL, MICROSERVICERUNTIME, SEMICROSERVICE,
        /// VIRTUALSERVICEANALYSIS, CLIENTINTERNAL, CLIENTSUMMARYINTERNAL, MICROSERVICEGROUPRUNTIME, BGPRUNTIME,
        /// REQUESTQUEUERUNTIME, MIGRATEALL, MIGRATEALLSTATUSSUMMARY, MIGRATEALLSTATUSDETAIL, INTERFACESUMMARYRUNTIME,
        /// INTERFACELACPRUNTIME, DNSTABLE, GSLBSERVICEDETAIL, GSLBSERVICEINTERNAL, GSLBSERVICEHMONSTAT, SETROLESREQUEST,
        /// TRAFFICCLONERUNTIME, GEOLOCATIONINFO, SEVSHBSTATRUNTIME, GEODBINTERNAL, GSLBSITEINTERNAL, WAFSTATS,
        /// USERDEFINEDDATASCRIPTCOUNTERS, LLDPRUNTIME, VSESSHARINGPOOL, NDTABLERUNTIME, IP6STATRUNTIME, ICMP6STATRUNTIME,
        /// SEVSSPLACEMENT, L4POLICYSETSTATS, L4POLICYSETINTERNAL, BGPDEBUGINFO, SHARD, CPUSTATRUNTIMEDETAIL, SEASSERTSTATRUNTIME,
        /// SEFAULTINJECTINFRA, SEAGENTASSERTSTATRUNTIME, SEDATASTORESTATUS, DIFFQUEUESTATUS, IP6ROUTETABLERUNTIME,
        /// SECURITYMGRSTATE, VIRTUALSERVICESESCALEOUTSTATUS, SHARDSERVERSTATUS, SEAGENTSHARDCLIENTRESOURCEMAP,
        /// SEAGENTCONSISTENTHASH, SEAGENTVNICDBHISTORY, SEAGENTSHARDCLIENTAPPMAP, SEAGENTSHARDCLIENTEVENTHISTORY, NATSTATRUNTIME,
        /// NATFLOWRUNTIME, SECUTIRYMGRRUNTIME, SSOPOLICYSTATS, SENETWORKSERVICERUNTIME, SEGEORUNTIME, NATPOLICYSTATS,
        /// SEFAULTRUNTIME, VIRTUALSERVICESCALEOUTSTATUS, VIRTUALSERVICESCALEOUTSTATUSDETAIL, SECURITYMGRLEARN, SECURITYMGRTOPN,
        /// SSLSESSIONCACHE, SEGEODETAILS, GSLBSERVICEALGOSTAT, HTTPCONNECTIONRUNTIME, HTTPCONNECTIONRUNTIMEDETAIL,
        /// REMOTESITEWATCHERSUMMARY, REMOTESITEWATCHEREVENT, IPREPUTATIONDBRUNTIME, SEFAULTINJECTEXHAUSTCFG,
        /// SEFAULTINJECTEXHAUSTSHMCFG, SEFAULTINJECTEXHAUSTSHMCONN, BGPRUNNINGCONFIG, BGPADVERTISEDROUTES, BGPPEERSTATUS,
        /// BFDSESSIONSTATUS, BGPPEERINFO, GSLBSITEOPSREPLICATIONPOLICYOPS, FEDERATEDDATASTORESTATUS, FEDERATEDDIFFQUEUESTATUS,
        /// ROUTESTATRUNTIME, ROUTEFLOWRUNTIME, NSXTSEGMENTRUNTIME, SERESOURCEPROTO, SECONSUMERPROTO, SECREATEPENDINGPROTO,
        /// PLACEMENTSTATS, SEVIPPROTO, RMVRFPROTO, VCENTERMAP, VIMGRVCENTERRUNTIME, INTERESTEDVMS, INTERESTEDHOSTS,
        /// VCENTERSUPPORTEDCOUNTERS, ENTITYCOUNTERS, TRANSACTIONSTATS, SEVMCREATEPROGRESS, PLACEMENTSTATUS, VISUBFOLDERS,
        /// VIDATASTORE, VIHOSTRESOURCES, CLOUDCONNECTOR, VINETWORKSUBNETVMS, VIDATASTORECONTENTS, VIMGRVCENTERCLOUDRUNTIME,
        /// VIVCENTERPORTGROUPS, VIVCENTERDATACENTERS, VIMGRHOSTRUNTIME, PLACEMENTGLOBALS, ALBSERVICES, RMCLOUDOPSPROTO,
        /// APICCONFIGURATION, CIFTABLE, APICTRANSACTION, VIRTUALSERVICESTATEDBCACHESUMMARY, POOLSTATEDBCACHESUMMARY,
        /// SERVERSTATEDBCACHESUMMARY, APICAGENTINTERNAL, APICTRANSACTIONFLAP, APICGRAPHINSTANCES, APICEPGS, APICEPGEPS,
        /// APICDEVICEPKGVER, APICTENANTS, APICVMMDOMAINS, NSXCONFIGURATION, NSXSGTABLE, NSXAGENTINTERNAL, NSXSGINFO, NSXSGIPS,
        /// NSXAGENTINTERNALCLI, NSXTAGENT, SERATELIMITINGRLINTERNAL, SERATELIMITINGMSFINTERNAL, MAXOBJECTS. Field introduced in
        /// 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "obj_types", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> ObjTypes { get; set; }
        /// <summary>
        /// Privilege granted for objects matched by the rule. Enum options - NO_ACCESS, READ_ACCESS, WRITE_ACCESS. Field introduced
        /// in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "privilege")]
        public string? Privilege { get; set; }
    }
}