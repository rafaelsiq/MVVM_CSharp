using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_OO.View.Blocks
{
    class Header
    {
        public Header(){}
        public void Cabecalho() {
            Console.WriteLine("Cabecalho da pagina");
        }
        public string Titulo()
        {
            return "Estripulia";
        }
    }
}
