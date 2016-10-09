using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreiosWebService
{
    public class CorreiosInfra
    {

        public void ConsultaCep(string cep)
        {
            try
            {
                var ws = new CoreriosService.AtendeClienteClient();
                var resposta = ws.consultaCEP(cep);
                
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Erro ao efetuar busca do CEP: {0}", ex.Message);
            }
        }       
    }
}
