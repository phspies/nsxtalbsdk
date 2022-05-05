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
    public class NSXTALBParamsInURIType 
    {
        /// <summary>
        /// Params info in hitted signature rule which has ARGS match element. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "param_info")]
        public IList<NSXTALBParamInURIType> ParamInfo { get; set; }
    }
}
