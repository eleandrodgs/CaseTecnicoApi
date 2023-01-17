using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTecnicoApi.Models
{
    public class VotesModel
    {
        public class Request
        {
            public string image_id { get; set; }
            public string sub_id { get; set; }
            public int value { get; set; }

        }

        public class Response
        {
            public string message { get; set; }
            public string id { get; set; }
            public string image_id { get; set; }
            public string sub_id { get; set;}
            public string value { get; set; }

        }
    }
}
