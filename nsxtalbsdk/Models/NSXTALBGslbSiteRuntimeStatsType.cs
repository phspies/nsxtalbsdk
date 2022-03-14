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
    public class NSXTALBGslbSiteRuntimeStatsType 
    {
        public NSXTALBGslbSiteRuntimeStatsType()
        {
        }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_file_cr_txed")]
        public int? NumFileCrTxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_file_del_txed")]
        public int? NumFileDelTxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_gap_cr_rxed")]
        public int? NumGapCrRxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_gap_cr_txed")]
        public int? NumGapCrTxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_gap_del_rxed")]
        public int? NumGapDelRxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_gap_del_txed")]
        public int? NumGapDelTxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_gap_upd_rxed")]
        public int? NumGapUpdRxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_gap_upd_txed")]
        public int? NumGapUpdTxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_geo_cr_rxed")]
        public int? NumGeoCrRxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_geo_cr_txed")]
        public int? NumGeoCrTxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_geo_del_rxed")]
        public int? NumGeoDelRxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_geo_del_txed")]
        public int? NumGeoDelTxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_geo_upd_rxed")]
        public int? NumGeoUpdRxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_geo_upd_txed")]
        public int? NumGeoUpdTxed { get; set; }
        /// <summary>
        /// Number of num_ghm_cr_rxed.
        /// </summary>
        [JsonProperty(PropertyName = "num_ghm_cr_rxed")]
        public int? NumGhmCrRxed { get; set; }
        /// <summary>
        /// Number of num_ghm_cr_txed.
        /// </summary>
        [JsonProperty(PropertyName = "num_ghm_cr_txed")]
        public int? NumGhmCrTxed { get; set; }
        /// <summary>
        /// Number of num_ghm_del_rxed.
        /// </summary>
        [JsonProperty(PropertyName = "num_ghm_del_rxed")]
        public int? NumGhmDelRxed { get; set; }
        /// <summary>
        /// Number of num_ghm_del_txed.
        /// </summary>
        [JsonProperty(PropertyName = "num_ghm_del_txed")]
        public int? NumGhmDelTxed { get; set; }
        /// <summary>
        /// Number of num_ghm_upd_rxed.
        /// </summary>
        [JsonProperty(PropertyName = "num_ghm_upd_rxed")]
        public int? NumGhmUpdRxed { get; set; }
        /// <summary>
        /// Number of num_ghm_upd_txed.
        /// </summary>
        [JsonProperty(PropertyName = "num_ghm_upd_txed")]
        public int? NumGhmUpdTxed { get; set; }
        /// <summary>
        /// Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "num_gjwt_cr_rxed")]
        public int? NumGjwtCrRxed { get; set; }
        /// <summary>
        /// Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "num_gjwt_cr_txed")]
        public int? NumGjwtCrTxed { get; set; }
        /// <summary>
        /// Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "num_gjwt_del_rxed")]
        public int? NumGjwtDelRxed { get; set; }
        /// <summary>
        /// Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "num_gjwt_del_txed")]
        public int? NumGjwtDelTxed { get; set; }
        /// <summary>
        /// Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "num_gjwt_upd_rxed")]
        public int? NumGjwtUpdRxed { get; set; }
        /// <summary>
        /// Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "num_gjwt_upd_txed")]
        public int? NumGjwtUpdTxed { get; set; }
        /// <summary>
        /// Number of num_glb_cr_rxed.
        /// </summary>
        [JsonProperty(PropertyName = "num_glb_cr_rxed")]
        public int? NumGlbCrRxed { get; set; }
        /// <summary>
        /// Number of num_glb_cr_txed.
        /// </summary>
        [JsonProperty(PropertyName = "num_glb_cr_txed")]
        public int? NumGlbCrTxed { get; set; }
        /// <summary>
        /// Number of num_glb_del_rxed.
        /// </summary>
        [JsonProperty(PropertyName = "num_glb_del_rxed")]
        public int? NumGlbDelRxed { get; set; }
        /// <summary>
        /// Number of num_glb_del_txed.
        /// </summary>
        [JsonProperty(PropertyName = "num_glb_del_txed")]
        public int? NumGlbDelTxed { get; set; }
        /// <summary>
        /// Number of num_glb_upd_rxed.
        /// </summary>
        [JsonProperty(PropertyName = "num_glb_upd_rxed")]
        public int? NumGlbUpdRxed { get; set; }
        /// <summary>
        /// Number of num_glb_upd_txed.
        /// </summary>
        [JsonProperty(PropertyName = "num_glb_upd_txed")]
        public int? NumGlbUpdTxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_gpki_cr_rxed")]
        public int? NumGpkiCrRxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_gpki_cr_txed")]
        public int? NumGpkiCrTxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_gpki_del_rxed")]
        public int? NumGpkiDelRxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_gpki_del_txed")]
        public int? NumGpkiDelTxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_gpki_upd_rxed")]
        public int? NumGpkiUpdRxed { get; set; }
        /// <summary>
        /// Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_gpki_upd_txed")]
        public int? NumGpkiUpdTxed { get; set; }
        /// <summary>
        /// Number of num_gs_cr_rxed.
        /// </summary>
        [JsonProperty(PropertyName = "num_gs_cr_rxed")]
        public int? NumGsCrRxed { get; set; }
        /// <summary>
        /// Number of num_gs_cr_txed.
        /// </summary>
        [JsonProperty(PropertyName = "num_gs_cr_txed")]
        public int? NumGsCrTxed { get; set; }
        /// <summary>
        /// Number of num_gs_del_rxed.
        /// </summary>
        [JsonProperty(PropertyName = "num_gs_del_rxed")]
        public int? NumGsDelRxed { get; set; }
        /// <summary>
        /// Number of num_gs_del_txed.
        /// </summary>
        [JsonProperty(PropertyName = "num_gs_del_txed")]
        public int? NumGsDelTxed { get; set; }
        /// <summary>
        /// Number of num_gs_upd_rxed.
        /// </summary>
        [JsonProperty(PropertyName = "num_gs_upd_rxed")]
        public int? NumGsUpdRxed { get; set; }
        /// <summary>
        /// Number of num_gs_upd_txed.
        /// </summary>
        [JsonProperty(PropertyName = "num_gs_upd_txed")]
        public int? NumGsUpdTxed { get; set; }
        /// <summary>
        /// Number of num_health_msgs_rxed.
        /// </summary>
        [JsonProperty(PropertyName = "num_health_msgs_rxed")]
        public int? NumHealthMsgsRxed { get; set; }
        /// <summary>
        /// Number of num_health_msgs_txed.
        /// </summary>
        [JsonProperty(PropertyName = "num_health_msgs_txed")]
        public int? NumHealthMsgsTxed { get; set; }
        /// <summary>
        /// Number of num_of_bad_responses.
        /// </summary>
        [JsonProperty(PropertyName = "num_of_bad_responses")]
        public int? NumOfBadResponses { get; set; }
        /// <summary>
        /// Number of num_of_events_generated.
        /// </summary>
        [JsonProperty(PropertyName = "num_of_events_generated")]
        public int? NumOfEventsGenerated { get; set; }
        /// <summary>
        /// Number of num_of_skip_outstanding_requests.
        /// </summary>
        [JsonProperty(PropertyName = "num_of_skip_outstanding_requests")]
        public int? NumOfSkipOutstandingRequests { get; set; }
        /// <summary>
        /// Number of num_of_timeouts.
        /// </summary>
        [JsonProperty(PropertyName = "num_of_timeouts")]
        public int? NumOfTimeouts { get; set; }
    }
}
