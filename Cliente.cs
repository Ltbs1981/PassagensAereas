using System;
using System.Collections.Generic;

namespace PassagensAereas
{
    public class Cliente
    {
        public string Nome { get; set; }
        private List<PassagemAerea> listaPedidos;

        public Cliente(string nome)
        {
            Nome = nome;
            listaPedidos = new List<PassagemAerea>();
        }

        public double TotalDasPassagens()
        {
            double total = 0;
            foreach (var pedido in listaPedidos)
            {
                total += pedido.CalcularPreco();
            }
            return total;
        }

        public void AdicionarPedido(PassagemAerea pedido)
        {
            listaPedidos.Add(pedido);
            Console.WriteLine("Passagem comprada com sucesso.");
        }

        public void ListarPedido()
        {
            if (listaPedidos.Count == 0)
            {
                Console.WriteLine("Você ainda não comprou nenhuma passagem aérea.");
                return;
            }

            for (int i = 0; i < listaPedidos.Count; i++)
            {
                Console.WriteLine($"Passagem {i + 1}: Origem: {listaPedidos[i].Origem}, Destino: {listaPedidos[i].Destino}, Data: {listaPedidos[i].Data}, Quantidade: {listaPedidos[i].Quantidades}, Total: {listaPedidos[i].CalcularPreco():C}");
            }
        }
    }
}
