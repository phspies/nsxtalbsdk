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
    public class NSXTALBPermissionType 
    {
        /// <summary>
        /// Enum options - PERMISSION_CONTROLLER, PERMISSION_INTERNAL, PERMISSION_VIRTUALSERVICE, PERMISSION_POOL,
        /// PERMISSION_HEALTHMONITOR, PERMISSION_NETWORKPROFILE, PERMISSION_APPLICATIONPROFILE, PERMISSION_HTTPPOLICYSET,
        /// PERMISSION_IPADDRGROUP, PERMISSION_STRINGGROUP, PERMISSION_SSLPROFILE, PERMISSION_SSLKEYANDCERTIFICATE,
        /// PERMISSION_NETWORKSECURITYPOLICY, PERMISSION_APPLICATIONPERSISTENCEPROFILE, PERMISSION_ANALYTICSPROFILE,
        /// PERMISSION_VSDATASCRIPTSET, PERMISSION_TENANT, PERMISSION_PKIPROFILE, PERMISSION_AUTHPROFILE, PERMISSION_CLOUD,
        /// PERMISSION_SERVICEENGINE, PERMISSION_SERVICEENGINEGROUP, PERMISSION_NETWORK, PERMISSION_SYSTEMCONFIGURATION,
        /// PERMISSION_VRFCONTEXT, PERMISSION_USER, PERMISSION_ROLE, PERMISSION_ALERT, PERMISSION_ALERTCONFIG,
        /// PERMISSION_ALERTEMAILCONFIG, PERMISSION_ALERTSYSLOGCONFIG, PERMISSION_ACTIONGROUPCONFIG, PERMISSION_SNMPTRAPPROFILE,
        /// PERMISSION_UPGRADE, PERMISSION_REBOOT, PERMISSION_TECHSUPPORT, PERMISSION_EXEMPT, PERMISSION_VIRTUALSERVICE_MAINTENANCE,
        /// PERMISSION_POOL_MAINTENANCE, PERMISSION_TRAFFIC_CAPTURE, PERMISSION_MICROSERVICEGROUP,
        /// PERMISSION_IPAMDNSPROVIDERPROFILE, PERMISSION_CERTIFICATEMANAGEMENTPROFILE, PERMISSION_POOLGROUP,
        /// PERMISSION_PRIORITYLABELS, PERMISSION_POOLGROUPDEPLOYMENTPOLICY, PERMISSION_GSLB, PERMISSION_GSLBSERVICE,
        /// PERMISSION_GSLBGEODBPROFILE, PERMISSION_DNSPOLICY, PERMISSION_TRAFFICCLONEPROFILE, PERMISSION_SE_TOKEN,
        /// PERMISSION_WAFPOLICY, PERMISSION_WAFPROFILE, PERMISSION_USER_CREDENTIAL, PERMISSION_AUTOSCALE,
        /// PERMISSION_CUSTOMIPAMDNSPROFILE, PERMISSION_ERRORPAGEPROFILE, PERMISSION_ERRORPAGEBODY, PERMISSION_L4POLICYSET,
        /// PERMISSION_MICROSERVICE, PERMISSION_HARDWARESECURITYMODULEGROUP, PERMISSION_SECURITYPOLICY,
        /// PERMISSION_WAFPOLICYPSMGROUP, PERMISSION_PINGACCESSAGENT, PERMISSION_NETWORKSERVICE, PERMISSION_NATPOLICY,
        /// PERMISSION_PROTOCOLPARSER, PERMISSION_SSOPOLICY, PERMISSION_CONTROLLERSITE, PERMISSION_IMAGE, PERMISSION_UPGRADE_OPS,
        /// PERMISSION_UPGRADE_SEGROUP_OPS, PERMISSION_TESTSEDATASTORELEVEL1, PERMISSION_TESTSEDATASTORELEVEL2,
        /// PERMISSION_TESTSEDATASTORELEVEL3, PERMISSION_FILE_OBJECT, PERMISSION_IPREPUTATIONDB, PERMISSION_ICAP,
        /// PERMISSION_GSLBSERVICE_GROUP, PERMISSION_JWTSERVERPROFILE, PERMISSION_GEODB, PERMISSION_BOTDETECTIONPOLICY,
        /// PERMISSION_JWTPROFILE, PERMISSION_LABELGROUP, PERMISSION_WAFCRS.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Resource { get; set; }
        /// <summary>
        /// Limits the scope of Write Access on the parent resource to modification of only the specified subresources. Field
        /// introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "subresource")]
        public NSXTALBSubResourceType Subresource { get; set; }
        /// <summary>
        /// Enum options - NO_ACCESS, READ_ACCESS, WRITE_ACCESS.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
