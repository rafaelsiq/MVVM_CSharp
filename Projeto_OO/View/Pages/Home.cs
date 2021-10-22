using System;
using System.Collections.Generic;
using System.Text;
using Projeto_OO.View.Blocks;


namespace Projeto_OO.View.Pages
{
    class Home
    {
        string Titulo;
        public Home() {
            Header headeres = new Header();
            Titulo = headeres.Titulo();
        }

        public void Show() {
            Header headeres = new Header();
            Console.WriteLine(Titulo);
            headeres.Cabecalho();
            Cliente cliente = new Cliente();
            cliente.NomeDoCliente();
            Console.WriteLine(cliente.TelefoneDoCliente());

Criei uma linha para testar

        }

    }
}
