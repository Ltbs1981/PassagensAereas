using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagensAereas
{
    public class PassagemAerea
    {

        public string  Origem { get; set; }
        public string Destino { get; set; }
            public string Data { get; set; }
        public int Quantidades { get; set; }
        public doublie Preco { get; set; }

        public PassagemAerea(string origem, string destino, string data, int quantidade, doublie preco)
        {
            Origem = origem;
            Destino = destino;
            Data = data;
            Quantidades = quantidade;
            Preco = preco;
        }
        public double CalcularPreco() => Preco * Quantidades;
    }
}
