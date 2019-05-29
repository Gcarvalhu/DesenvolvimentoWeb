using Microsoft.Extensions.Primitives;

namespace Estacionamento.Models {
    public class VeiculoModel {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }

        public VeiculoModel (string nome, string email, string modelo, string marca, string placa) {
            this.Nome = nome;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Placa = placa;
        }

        public VeiculoModel(StringValues nome, StringValues modelo, StringValues marca, StringValues placa)
        {
            Nome = nome;
            Modelo = modelo;
            Marca = marca;
            Placa = placa;
        }
    }
}