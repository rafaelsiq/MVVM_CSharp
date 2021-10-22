using System;
using System.Collections.Generic;
using System.Text;
using Projeto_OO.Model.DataBase;
using Projeto_OO.Model.Entitys;
using Projeto_OO.Model.Model;
namespace Projeto_OO.Model.Repositories
{
    class DataSource
    {
        public string GetCliente() {
            Data data = new Data();
            Clientes clientes = RepositoresToDatabase.DatabaseToEntitys(data);
            
            return clientes.nome;
        }
        
    }
}
