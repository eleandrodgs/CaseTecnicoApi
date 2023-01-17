using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTecnicoApi.Helpers
{
    public static class RestResponseExtensions
    {
        public static string GetResponseObject(this RestResponse response, string responseObject)
        {
            JObject jsonObject = JObject.Parse(response.Content);
            return jsonObject[responseObject].ToString();
        }
    }
}
