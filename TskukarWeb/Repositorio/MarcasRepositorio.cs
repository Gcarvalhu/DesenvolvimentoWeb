using System.Collections.Generic;
using System.IO;
using TskukarWeb.Models;

namespace TskukarWeb.Repositorio
{
    public class MarcasRepositorio
    {
        public List<MarcaModel> Listar(){
            List<MarcaModel> listaDeMarcas = new List<MarcaModel>();
            string[] linhas = File.ReadAllLines("Database/marcas.csv");
            MarcaModel marca;

            foreach (var item in linhas)
            {
                if(string.IsNullOrEmpty(item)){
                    continue;
                }
                string[] linha = item.Split(";");
                marca = new MarcaModel(
                    id: int.Parse(linha[0]),
                    nome: linha[1]

                );
                listaDeMarcas.Add(marca);
            }
            return listaDeMarcas;
        }//fim de listar 
    }
}