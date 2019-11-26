using Abp;
using Abp.Application.Services;
using Abp.AspNetCore.SignalR.Hubs;
using Abp.Dependency;
using Microsoft.AspNetCore.SignalR;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using TEST.DataServiceApplication.Models;

namespace TEST.DataServiceApplication
{
    public class DataServiceProviderAppService : AbpHubBase, ITransientDependency, IApplicationService
    {

        private FilterBuilder _filterBuilder;

        public DataServiceProviderAppService(FilterBuilder filterBuilder)
        {
            _filterBuilder = filterBuilder;
        }


        public async Task SendMessage(string message)
        {
            //await Clients.All.SendAsync("getMessage", string.Format("User {0}: {1}", AbpSession.UserId, message));
            await Clients.Client(Context.ConnectionId).SendAsync("getMessage", string.Format("User {0}: {1}", Context.ConnectionId, message));

        }

        public void Register()
        {
            Logger.Debug("A client is registered: " + Context.ConnectionId);
        }

        public async Task SendRequestTest(string requestString)
        {
            dynamic requestObject = JsonConvert.DeserializeObject<dynamic>(requestString);
            string command = requestObject["command"];
            var parameters = requestObject["parameters"];
            string rid = requestObject["rid"];
            var source = parameters["source"];

            ResponseModel responsedata = await CompileData(parameters);

            await Clients.All.SendAsync("getGamedata", responsedata);
        }


        public async Task<ResponseModel> CompileData(dynamic parameters)
        {

            FilterDefinition<Event> condition = _filterBuilder.GetFilterConditions(parameters);

            var dataObject = new JObject();

            dataObject.Add(
                new JProperty("Test", "Hi")
                ); ;

            var response = new ResponseModel
            {
                code = 0,
                data = new DataModel
                {
                    data = dataObject
                },

            };

            return response;

        }

        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
            Logger.Debug("A client connected to MyChatHub: " + Context.ConnectionId);
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await base.OnDisconnectedAsync(exception);
            Logger.Debug("A client disconnected from MyChatHub: " + Context.ConnectionId);
        }


    }
}