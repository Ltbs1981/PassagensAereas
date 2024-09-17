using System;

namespace PassagensAereas
{
    public class PassagemPrimeiraClasse : PassagemAerea
    {
        public double AdicionalPrimeiraClasse { get; set; }

        public PassagemPrimeiraClasse(string origem, string destino, string data, int quantidade, double preco) // Corrigido aqui
            : base(origem, destino, data, quantidade, preco)
        {
            AdicionalPrimeiraClasse = 0.5; 
        }

        public override double CalcularPreco()
        {
            return Preco * Quantidades * (1 + AdicionalPrimeiraClasse);
        }
    }
}
