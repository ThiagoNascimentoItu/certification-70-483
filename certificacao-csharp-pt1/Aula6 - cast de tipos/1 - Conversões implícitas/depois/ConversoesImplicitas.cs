using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            int inteiro = 2_123_456_789;
            long inteiroLogo = inteiro;

            Console.WriteLine($"Inteiro longo: {inteiroLogo}");

            Gato gato = new Gato();
            Animal animal = gato;

            IAnimal ianimal = gato;

            Console.WriteLine(ianimal.GetType());

            gato = (Gato)animal;


        }
    }
}

