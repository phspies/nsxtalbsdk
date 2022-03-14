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
    public class NSXTALBAutoScaleMesosSettingsType 
    {
        public NSXTALBAutoScaleMesosSettingsType()
        {
        }
        /// <summary>
        /// Apply scale-out even when there are deployments inprogress.
        /// </summary>
        [JsonProperty(PropertyName = "force")]
        public bool? Force { get; set; }
    }
}
