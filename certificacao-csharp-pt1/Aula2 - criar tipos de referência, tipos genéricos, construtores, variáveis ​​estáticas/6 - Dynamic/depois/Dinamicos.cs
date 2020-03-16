using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            object objeto = 1;

            dynamic dinamico = 1;

            dinamico = dinamico + 3;
        }
    }
}
