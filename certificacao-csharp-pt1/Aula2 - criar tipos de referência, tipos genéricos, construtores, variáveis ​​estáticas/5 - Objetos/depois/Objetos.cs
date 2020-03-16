using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"pontuacao: {pontuacao}");
            Console.WriteLine("Objeto:");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"Meu Objeto: {meuObjeto }");


            Console.WriteLine($"Meu Objeto referencia");

            meuObjeto = new Jogador();
            Jogador classRef;
            classRef =  (Jogador)meuObjeto;
            Console.WriteLine($"Meu Objeto: {meuObjeto }");
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
