using CorreiosDominio.Entidade;
using CorreiosService.Repositorio;

namespace CorreiosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CorreiosRepositorio _repostorioCorreio = new CorreiosRepositorio();            
                                       
            try
            {
                Cep resposta = _repostorioCorreio.ConsultaCep("14055230");

                System.Console.WriteLine();
                System.Console.WriteLine("Endereço: {0}", resposta.end);
                System.Console.WriteLine("Complemento: {0}", resposta.complemento);
                System.Console.WriteLine("Complemento 2: {0}", resposta.complemento2);
                System.Console.WriteLine("Bairro: {0}", resposta.bairro);
                System.Console.WriteLine("Cidade: {0}", resposta.cidade);
                System.Console.WriteLine("Estado: {0}", resposta.uf);                
            }
            catch
            {
                System.Console.WriteLine("Erro ao efetuar busca do CEP");
            }            
            System.Console.ReadLine();
        }       
    }
}
