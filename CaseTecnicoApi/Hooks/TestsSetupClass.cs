using CaseTecnicoApi.Base;
using CaseTecnicoApi.Helpers;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CaseTecnicoApi.Hooks
{
    [SetUpFixture]
    public class TestsSetupClass
    {
        public IConfiguration _dataConfig;
        public Settings _settings = new Settings();

        [SetUp]
        public void GlobalSetup()        {
            
             _dataConfig = Configuration.InitEnvironment();
            string api = _dataConfig["UrlApi"];
            _settings.RestClient = new RestClient(api);

        }

    }
}
