using CorreiosDominio.Entidade;

namespace CorreiosService.Repositorio
{
    public class CorreiosRepositorio
    {
        public Cep ConsultaCep(string cep)
        {
            var ws = new WSCorreios.AtendeClienteClient();
            var resposta = ws.consultaCEP(cep);

            return  new Cep
            {
                ceps = resposta.cep,
                end = resposta.end,
                complemento = resposta.complemento,
                complemento2 = resposta.complemento2,
                bairro = resposta.bairro,
                cidade = resposta.cidade,
                uf = resposta.uf,
            };            
        }
    }
}
