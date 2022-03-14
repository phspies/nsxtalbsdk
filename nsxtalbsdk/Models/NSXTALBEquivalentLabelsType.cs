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
    public class NSXTALBEquivalentLabelsType 
    {
        public NSXTALBEquivalentLabelsType()
        {
        }
        /// <summary>
        /// Equivalent labels.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<string> Labels { get; set; }
    }
}
