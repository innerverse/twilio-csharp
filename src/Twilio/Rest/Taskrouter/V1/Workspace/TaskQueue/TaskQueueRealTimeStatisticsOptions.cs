/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace.TaskQueue
{

    /// <summary>
    /// FetchTaskQueueRealTimeStatisticsOptions
    /// </summary>
    public class FetchTaskQueueRealTimeStatisticsOptions : IOptions<TaskQueueRealTimeStatisticsResource>
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The task_queue_sid
        /// </summary>
        public string PathTaskQueueSid { get; }
        /// <summary>
        /// Filter real-time and cumulative statistics by TaskChannel.
        /// </summary>
        public string TaskChannel { get; set; }

        /// <summary>
        /// Construct a new FetchTaskQueueRealTimeStatisticsOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathTaskQueueSid"> The task_queue_sid </param>
        public FetchTaskQueueRealTimeStatisticsOptions(string pathWorkspaceSid, string pathTaskQueueSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathTaskQueueSid = pathTaskQueueSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }

            return p;
        }
    }

}