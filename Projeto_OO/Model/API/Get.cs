]using System;
using System.Collections.Generic;
using System.Text;
using Projeto_OO.Model.Model;
using Projeto_OO.Model.Repositories;

namespace Projeto_OO.Model.API
{
    class Get
    {
        public Get() {
            
        }
        public string GetClienteNome() {
            DataSource data = new DataSource();

            return data.GetCliente();
        }
    }
}
