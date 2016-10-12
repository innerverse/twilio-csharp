using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Worker {

    public class WorkerChannelResource : SidResource {
        /**
         * read
         * 
         * @param workspaceSid The workspace_sid
         * @param workerSid The worker_sid
         * @return WorkerChannelReader capable of executing the read
         */
        public static WorkerChannelReader Reader(string workspaceSid, string workerSid) {
            return new WorkerChannelReader(workspaceSid, workerSid);
        }
    
        /**
         * fetch
         * 
         * @param workspaceSid The workspace_sid
         * @param workerSid The worker_sid
         * @param sid The sid
         * @return WorkerChannelFetcher capable of executing the fetch
         */
        public static WorkerChannelFetcher Fetcher(string workspaceSid, string workerSid, string sid) {
            return new WorkerChannelFetcher(workspaceSid, workerSid, sid);
        }
    
        /**
         * update
         * 
         * @param workspaceSid The workspace_sid
         * @param workerSid The worker_sid
         * @param sid The sid
         * @return WorkerChannelUpdater capable of executing the update
         */
        public static WorkerChannelUpdater Updater(string workspaceSid, string workerSid, string sid) {
            return new WorkerChannelUpdater(workspaceSid, workerSid, sid);
        }
    
        /**
         * Converts a JSON string into a WorkerChannelResource object
         * 
         * @param json Raw JSON string
         * @return WorkerChannelResource object represented by the provided JSON
         */
        public static WorkerChannelResource FromJson(string json) {
            // Convert all checked exceptions to Runtime
            try {
                return JsonConvert.DeserializeObject<WorkerChannelResource>(json);
            } catch (JsonException e) {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        private readonly string accountSid;
        [JsonProperty("assigned_tasks")]
        private readonly int? assignedTasks;
        [JsonProperty("available")]
        private readonly bool? available;
        [JsonProperty("available_capacity_percentage")]
        private readonly int? availableCapacityPercentage;
        [JsonProperty("configured_capacity")]
        private readonly int? configuredCapacity;
        [JsonProperty("date_created")]
        private readonly DateTime? dateCreated;
        [JsonProperty("date_updated")]
        private readonly DateTime? dateUpdated;
        [JsonProperty("sid")]
        private readonly string sid;
        [JsonProperty("task_channel_sid")]
        private readonly string taskChannelSid;
        [JsonProperty("task_channel_unique_name")]
        private readonly string taskChannelUniqueName;
        [JsonProperty("worker_sid")]
        private readonly string workerSid;
        [JsonProperty("workspace_sid")]
        private readonly string workspaceSid;
        [JsonProperty("links")]
        private readonly Dictionary<string, string> links;
        [JsonProperty("url")]
        private readonly Uri url;
    
        public WorkerChannelResource() {
        
        }
    
        private WorkerChannelResource([JsonProperty("account_sid")]
                                      string accountSid, 
                                      [JsonProperty("assigned_tasks")]
                                      int? assignedTasks, 
                                      [JsonProperty("available")]
                                      bool? available, 
                                      [JsonProperty("available_capacity_percentage")]
                                      int? availableCapacityPercentage, 
                                      [JsonProperty("configured_capacity")]
                                      int? configuredCapacity, 
                                      [JsonProperty("date_created")]
                                      string dateCreated, 
                                      [JsonProperty("date_updated")]
                                      string dateUpdated, 
                                      [JsonProperty("sid")]
                                      string sid, 
                                      [JsonProperty("task_channel_sid")]
                                      string taskChannelSid, 
                                      [JsonProperty("task_channel_unique_name")]
                                      string taskChannelUniqueName, 
                                      [JsonProperty("worker_sid")]
                                      string workerSid, 
                                      [JsonProperty("workspace_sid")]
                                      string workspaceSid, 
                                      [JsonProperty("links")]
                                      Dictionary<string, string> links, 
                                      [JsonProperty("url")]
                                      Uri url) {
            this.accountSid = accountSid;
            this.assignedTasks = assignedTasks;
            this.available = available;
            this.availableCapacityPercentage = availableCapacityPercentage;
            this.configuredCapacity = configuredCapacity;
            this.dateCreated = MarshalConverter.DateTimeFromString(dateCreated);
            this.dateUpdated = MarshalConverter.DateTimeFromString(dateUpdated);
            this.sid = sid;
            this.taskChannelSid = taskChannelSid;
            this.taskChannelUniqueName = taskChannelUniqueName;
            this.workerSid = workerSid;
            this.workspaceSid = workspaceSid;
            this.links = links;
            this.url = url;
        }
    
        /**
         * @return The account_sid
         */
        public string GetAccountSid() {
            return this.accountSid;
        }
    
        /**
         * @return The assigned_tasks
         */
        public int? GetAssignedTasks() {
            return this.assignedTasks;
        }
    
        /**
         * @return The available
         */
        public bool? GetAvailable() {
            return this.available;
        }
    
        /**
         * @return The available_capacity_percentage
         */
        public int? GetAvailableCapacityPercentage() {
            return this.availableCapacityPercentage;
        }
    
        /**
         * @return The configured_capacity
         */
        public int? GetConfiguredCapacity() {
            return this.configuredCapacity;
        }
    
        /**
         * @return The date_created
         */
        public DateTime? GetDateCreated() {
            return this.dateCreated;
        }
    
        /**
         * @return The date_updated
         */
        public DateTime? GetDateUpdated() {
            return this.dateUpdated;
        }
    
        /**
         * @return The sid
         */
        public override string GetSid() {
            return this.sid;
        }
    
        /**
         * @return The task_channel_sid
         */
        public string GetTaskChannelSid() {
            return this.taskChannelSid;
        }
    
        /**
         * @return The task_channel_unique_name
         */
        public string GetTaskChannelUniqueName() {
            return this.taskChannelUniqueName;
        }
    
        /**
         * @return The worker_sid
         */
        public string GetWorkerSid() {
            return this.workerSid;
        }
    
        /**
         * @return The workspace_sid
         */
        public string GetWorkspaceSid() {
            return this.workspaceSid;
        }
    
        /**
         * @return The links
         */
        public Dictionary<string, string> GetLinks() {
            return this.links;
        }
    
        /**
         * @return The url
         */
        public Uri GetUrl() {
            return this.url;
        }
    }
}