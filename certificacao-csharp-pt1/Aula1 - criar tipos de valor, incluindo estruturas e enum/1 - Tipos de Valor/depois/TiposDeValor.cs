using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade = 30;
            Console.WriteLine(idade);
            int copiaIdade = idade;

            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"Copia idade: {copiaIdade}");
            int? idade2 = null;
        }
    }
}
