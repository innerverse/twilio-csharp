using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Fetchers;
using Twilio.Http;
using Twilio.Resources.Taskrouter.V1;

namespace Twilio.Fetchers.Taskrouter.V1 {

    public class WorkspaceFetcher : Fetcher<WorkspaceResource> {
        private string sid;
    
        /**
         * Construct a new WorkspaceFetcher
         * 
         * @param sid The sid
         */
        public WorkspaceFetcher(string sid) {
            this.sid = sid;
        }
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the fetch
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Fetched WorkspaceResource
         */
        public override async Task<WorkspaceResource> ExecuteAsync(ITwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Get,
                Domains.TASKROUTER,
                "/v1/Workspaces/" + this.sid + ""
            );
            
            Response response = await client.RequestAsync(request);
            
            if (response == null) {
                throw new ApiConnectionException("WorkspaceResource fetch failed: Unable to connect to server");
            } else if (response.GetStatusCode() != HttpStatus.HTTP_STATUS_CODE_OK) {
                RestException restException = RestException.FromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.GetMessage(),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    restException.GetStatus(),
                    null
                );
            }
            
            return WorkspaceResource.FromJson(response.GetContent());
        }
        #endif
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the fetch
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Fetched WorkspaceResource
         */
        public override WorkspaceResource Execute(ITwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Get,
                Domains.TASKROUTER,
                "/v1/Workspaces/" + this.sid + ""
            );
            
            Response response = client.Request(request);
            
            if (response == null) {
                throw new ApiConnectionException("WorkspaceResource fetch failed: Unable to connect to server");
            } else if (response.GetStatusCode() != HttpStatus.HTTP_STATUS_CODE_OK) {
                RestException restException = RestException.FromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.GetMessage(),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    restException.GetStatus(),
                    null
                );
            }
            
            return WorkspaceResource.FromJson(response.GetContent());
        }
        #endif
    }
}