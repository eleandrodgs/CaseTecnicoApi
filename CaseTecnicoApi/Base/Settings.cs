using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTecnicoApi.Base
{
    public class Settings
    {
        public string BaseUrl { get; set; }
        public RestResponse Response { get; set; } = new RestResponse();
        public RestRequest Request { get; set; }
        public RestClient RestClient { get; set; } = new RestClient();
    }
}
