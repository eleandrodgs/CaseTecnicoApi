using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTecnicoApi.Models
{
    public class ConsultaVotesModel
    {
        public int id {get; set; }
        public string user_id { get; set; }
        public string image_id { get; set; }
        public string sub_id { get; set;}
        public DateTime created_at { get; set; }
        public int value { get; set;}
        public string country_code { get; set; }
        public string country_name { get; set;}
        public object image { get; set; }
    }
}
