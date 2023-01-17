using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTecnicoApi.Helpers
{
    public static class RestClientExtensions
    {
        private static IConfiguration _dataConfig = Configuration.InitEnvironment();

        public static RestResponse<T> ExecuteRequest<T>(this RestClient client, RestRequest request) where T : class, new()
        {
            var taskCompletionSource = new TaskCompletionSource<RestResponse<T>>();
            request.AddHeader("x-api-key", _dataConfig["Autorizacao"]);
            RestResponse<T> restResponse = Task.Run(() => client.ExecuteAsync<T>(request)).Result;
            taskCompletionSource.SetResult(restResponse);
            return restResponse;
        }
    }
}
