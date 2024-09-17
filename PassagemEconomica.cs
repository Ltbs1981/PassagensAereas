using System;

namespace PassagensAereas
{
    public class PassagemEconomica : PassagemAerea
    {
        public double DescontoClasseEconomica { get; set; }

        public PassagemEconomica(string origem, string destino, string data, int quantidade, double preco) // Corrigido aqui
            : base(origem, destino, data, quantidade, preco)
        {
            DescontoClasseEconomica = 0.1; 
        }

        public override double CalcularPreco()
        {
            return Preco * Quantidades * (1 - DescontoClasseEconomica);
        }
    }
}
