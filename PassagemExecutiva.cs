using System;

namespace PassagensAereas
{
    public class PassagemExecutiva : PassagemAerea
    {
        public double AdicionalExecutiva { get; set; }

        public PassagemExecutiva(string origem, string destino, string data, int quantidade, double preco) // Corrigido aqui
            : base(origem, destino, data, quantidade, preco)
        {
            AdicionalExecutiva = 0.3; 
        }

        public override double CalcularPreco()
        {
            return Preco * Quantidades * (1 + AdicionalExecutiva);
        }
    }
}
