using System;
using System.IO;
using Hmaburgueria_MVC.Models;

namespace Hmaburgueria_MVC.Repositorio
{
    public class PedidoRepositorio
    {
        public bool Inserir(Pedido pedido)
        {
            try{

            if(!File.Exists("Database/Pedido.csv")){
                //Codigo de criação do arquivo
                File.Create("Database/Pedido.csv").Close();
            }
            var registro = $"{pedido.Id};{pedido.Cliente.Nome};{pedido.Cliente.Endereco};{pedido.Cliente.Telefone};{pedido.Cliente.Email};{pedido.DataPedido};{pedido.Hamburguer};{pedido.Shake}\n";
                //Codigo de gravação  
            File.AppendAllText("Database/Pedido.csv",registro);
            }catch(Exception e){
                System.Console.WriteLine("Chegou no catch!");
                System.Console.WriteLine(e.StackTrace);
            }

            return true;                 
        }
    }
}