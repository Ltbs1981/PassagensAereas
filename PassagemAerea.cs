using System;

namespace PassagensAereas
{
    public class PassagemAerea
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string Data { get; set; }
        public int Quantidades { get; set; }
        public double Preco { get; set; } // Corrigido aqui

        public PassagemAerea(string origem, string destino, string data, int quantidade, double preco) // Corrigido aqui
        {
            Origem = origem;
            Destino = destino;
            Data = data;
            Quantidades = quantidade;
            Preco = preco;
        }

        public virtual double CalcularPreco() => Preco * Quantidades;
    }
}
