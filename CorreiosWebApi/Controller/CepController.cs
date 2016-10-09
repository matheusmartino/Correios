using CorreiosDominio.Entidade;
using CorreiosService.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CorreiosWebApi.Controller
{
    [RoutePrefix("api")]

    public class CepController : ApiController
    {             
        [HttpGet]
        [Route("cep/consulta/{cep}")]
        public HttpResponseMessage ConsultaCep(string cep)
        {
            try
            {
                var ws = new WSCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(cep);

                Cep ceps = new Cep
                {

                    ceps = resposta.cep,
                    end = resposta.end,
                    complemento = resposta.complemento,
                    complemento2 = resposta.complemento2,
                    bairro = resposta.bairro,
                    cidade = resposta.cidade,
                    uf = resposta.uf,
                };                
                return Request.CreateResponse(HttpStatusCode.OK, ceps);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("cep/consulta/{cep}/json")]
        public HttpResponseMessage ConsultaCepJson(string cep)
        {
            try
            {
                var ws = new WSCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(cep);

                Cep ceps = new Cep
                {
                    ceps = resposta.cep,
                    end = resposta.end,
                    complemento = resposta.complemento,
                    complemento2 = resposta.complemento2,
                    bairro = resposta.bairro,
                    cidade = resposta.cidade,
                    uf = resposta.uf,
                };
                return Request.CreateResponse(HttpStatusCode.OK, ceps);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}