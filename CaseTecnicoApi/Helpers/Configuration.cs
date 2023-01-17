using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTecnicoApi.Helpers
{
    public static class Configuration
    {
        public static IConfiguration Init(string fileName)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(fileName)
                .Build();
            return config;
        }

        public static IConfiguration InitEnvironment()
        {            
            return Init("appSettings.json");
        }
    }
}
