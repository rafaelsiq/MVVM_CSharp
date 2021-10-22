using System;
using System.Collections.Generic;
using System.Text;
using Projeto_OO.Model.Entitys;
using Projeto_OO.Model.DataBase;
namespace Projeto_OO.Model.Model
{
    class RepositoresToDatabase
    {
        static public Data EntitysToDatabase(Clientes clientes) {
            Data data = new Data();
            data.nome = clientes.nome;
            data.telefone = clientes.telefone;
            return data;
        }
        static public Clientes DatabaseToEntitys(Data data)
        {
            Clientes clientes = new Clientes();
            clientes.nome = data.nome;
            clientes.telefone = data.telefone;
            return clientes;
        }

    }
}
