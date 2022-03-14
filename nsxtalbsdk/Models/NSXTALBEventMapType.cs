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
    public class NSXTALBEventMapType 
    {
        public NSXTALBEventMapType()
        {
        }
        /// <summary>
        /// List of all events node wise.(Not in use). Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "nodes_events")]
        public IList<NSXTALBUpgradeEventType> NodesEvents { get; set; }
        /// <summary>
        /// List of all events node wise. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "sub_events")]
        public IList<NSXTALBUpgradeEventType> SubEvents { get; set; }
        /// <summary>
        /// Enum representing the task.(Not in use). Enum options - PREPARE_FOR_SHUTDOWN, COPY_AND_VERIFY_IMAGE, INSTALL_IMAGE,
        /// POST_INSTALL_HOOKS, PREPARE_CONTROLLER_FOR_SHUTDOWN, STOP_CONTROLLER, EXTRACT_PATCH_IMAGE, EXECUTE_PRE_INSTALL_COMMANDS,
        /// INSTALL_PATCH_IMAGE, PREPARE_FOR_REBOOT_CONTROLLER_NODES, REBOOT_CONTROLLER_NODES, WAIT_FOR_ALL_CONTROLLER_NODES_ONLINE,
        /// PRE_UPGRADE_HOOKS, MIGRATE_CONFIG, START_PRIMARY_CONTROLLER, START_ALL_CONTROLLERS, POST_UPGRADE_HOOKS,
        /// EXECUTE_POST_INSTALL_COMMANDS, SET_CONTROLLER_UPGRADE_COMPLETED, STATE_NOT_USED_IN_V2, COMMIT_UPGRADE, UNKNOWN_TASK,
        /// PATCH_CONTROLLER_HEALTH_CHECK. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "task")]
        public string? Task { get; set; }
        /// <summary>
        /// Name representing the task. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "task_name")]
        public string? TaskName { get; set; }
    }
}
