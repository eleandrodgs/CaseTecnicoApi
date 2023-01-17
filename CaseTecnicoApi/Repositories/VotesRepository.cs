using CaseTecnicoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTecnicoApi.Repositories
{
    public class VotesRepository
    {
        public VotesModel.Request RetornaBodyParaCadastrarVoto(int valor)
        {
            VotesModel.Request dados = new VotesModel.Request()
            {
                image_id = "asf2",
                sub_id = "my-user-1234",
                value = valor
            };

            return dados;
        }
    }
}
