using CaseTecnicoApi.Base;
using CaseTecnicoApi.Helpers;
using CaseTecnicoApi.Hooks;
using CaseTecnicoApi.Models;
using CaseTecnicoApi.Repositories;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net;

namespace CaseTecnicoApi.Tests
{
    [TestFixture]
    public class VotesTests : TestsSetupClass
    {        
        private VotesRepository _votesRepository = new VotesRepository();
        private static IConfiguration _dataConfig = Configuration.InitEnvironment();
        private string _idCadastro = "";              
        

       [Test]
        public void CadastrarVotoUp()
        {            
            _settings.Request = new RestRequest(_settings.BaseUrl + "/v1/votes", Method.Post);            
            _settings.Request.AddBody(_votesRepository.RetornaBodyParaCadastrarVoto(1));

            _settings.Response = _settings.RestClient.ExecuteRequest<VotesModel.Response>(_settings.Request);
            
            Assert.That(_settings.Response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
            Assert.IsNotEmpty(_settings.Response.Content);

            var dadosReposta = JsonConvert.DeserializeObject<VotesModel.Response>(_settings.Response.Content);
            Assert.That(dadosReposta.message, Is.EqualTo("SUCCESS"));

            _idCadastro = dadosReposta.id;

        }

        [Test]
        public void ConsultarVoto()
        {
            CadastrarVotoUp();

            _settings.Request = new RestRequest(_settings.BaseUrl + "/v1/votes/{idVoto}", Method.Get);
            _settings.Request.AddUrlSegment("idVoto", _idCadastro);
            _settings.Response = _settings.RestClient.ExecuteRequest<ConsultaVotesModel>(_settings.Request);

            var dadosReposta = JsonConvert.DeserializeObject<ConsultaVotesModel>(_settings.Response.Content);
            Assert.That(dadosReposta.id, Is.EqualTo(Int32.Parse(_idCadastro)));

        }


        [Test]
        public void ConsultarVotoInexistente()
        {            
            _settings.Request = new RestRequest(_settings.BaseUrl + "/v1/votes/{idVoto}", Method.Get);
            _settings.Request.AddUrlSegment("idVoto", "965874");
            _settings.Response = _settings.RestClient.ExecuteRequest<ConsultaVotesModel>(_settings.Request);

            Assert.That(_settings.Response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
            Assert.That(_settings.Response.Content, Is.EqualTo("NOT_FOUND"));

        }

        [Test]
        public void DeletarVoto()
        {
            CadastrarVotoUp();

            _settings.Request = new RestRequest(_settings.BaseUrl + "/v1/votes/{idVoto}", Method.Delete);
            _settings.Request.AddUrlSegment("idVoto", _idCadastro);
            _settings.Response = _settings.RestClient.ExecuteRequest<JObject>(_settings.Request);

            Assert.That(_settings.Response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(_settings.Response.GetResponseObject("message"), Is.EqualTo("SUCCESS"));

        }

        [Test]
        public void DeletarVotoInexistente()
        {
            _settings.Request = new RestRequest(_settings.BaseUrl + "/v1/votes/{idVoto}", Method.Delete);
            _settings.Request.AddUrlSegment("idVoto", "965874");
            _settings.Response = _settings.RestClient.ExecuteRequest<JObject>(_settings.Request);

            Assert.That(_settings.Response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
            Assert.That(_settings.Response.Content, Is.EqualTo("NO_VOTE_FOUND_MATCHING_ID"));

        }
    }
}
