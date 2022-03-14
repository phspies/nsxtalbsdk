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
    public class NSXTALBAWSLoginType 
    {
        /// <summary>
        /// access_key_id of AWSLogin.
        /// </summary>
        [JsonProperty(PropertyName = "access_key_id")]
        public string? AccessKeyId { get; set; }
        /// <summary>
        /// iam_assume_role of AWSLogin.
        /// </summary>
        [JsonProperty(PropertyName = "iam_assume_role")]
        public string? IamAssumeRole { get; set; }
        /// <summary>
        /// AWS region.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string? Region { get; set; }
        /// <summary>
        /// secret_access_key of AWSLogin.
        /// </summary>
        [JsonProperty(PropertyName = "secret_access_key")]
        public string? SecretAccessKey { get; set; }
        /// <summary>
        /// Placeholder for description of property use_iam_roles of obj type AWSLogin field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "use_iam_roles")]
        public bool? UseIamRoles { get; set; }
        /// <summary>
        /// vpc_id of AWSLogin.
        /// </summary>
        [JsonProperty(PropertyName = "vpc_id")]
        public string? VpcId { get; set; }
    }
}
