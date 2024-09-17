using System;

namespace PassagensAereas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cliente cliente = new Cliente("Luciano");

            //2 exemplos de cada passagem por tipo
            PassagemEconomica passagemEconomica1 = new PassagemEconomica("São Paulo", "Rio de Janeiro", "12/12/2024", 10, 300.0);
            cliente.AdicionarPedido(passagemEconomica1);

            PassagemEconomica passagemEconomica2 = new PassagemEconomica("Rio de Janeiro", "São Paulo", "15/12/2024", 2, 280.0);
            cliente.AdicionarPedido(passagemEconomica2);

            
            PassagemExecutiva passagemExecutiva1 = new PassagemExecutiva("Brasília", "Curitiba", "10/01/2024", 1, 500.0);
            cliente.AdicionarPedido(passagemExecutiva1);

            PassagemExecutiva passagemExecutiva2 = new PassagemExecutiva("Curitiba", "Brasília", "13/01/2024", 2, 480.0);
            cliente.AdicionarPedido(passagemExecutiva2);


            PassagemPrimeiraClasse passagemPrimeiraClasse1 = new PassagemPrimeiraClasse("Salvador", "Fortaleza", "20/02/2024", 1, 1000.0);
            cliente.AdicionarPedido(passagemPrimeiraClasse1);

            PassagemPrimeiraClasse passagemPrimeiraClasse2 = new PassagemPrimeiraClasse("Fortaleza", "Salvador", "25/02/2024", 2, 950.0);
            cliente.AdicionarPedido(passagemPrimeiraClasse2);

            // lista passagens
            cliente.ListarPedido();

            // preço total de passagens 
            Console.WriteLine($"Total geral das passagens: {cliente.TotalDasPassagens():C}");

            Console.ReadLine();
        }
    }
}
