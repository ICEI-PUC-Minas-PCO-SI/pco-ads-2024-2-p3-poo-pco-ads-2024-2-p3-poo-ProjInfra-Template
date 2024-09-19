

using System.Diagnostics;

namespace com.aluno.veiculos.entidades.veiculos
{
    public class Veiculo
    {
        // Propriedades privadas com getters e setters
        protected string Tipo { get; set; }
        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        protected string Cor { get; set; }
        protected int Ano { get; set; }

        // Construtor
        public Veiculo(string tipo, string marca, string modelo, string cor, int ano)
        {
            this.Tipo = tipo;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Ano = ano;
        }

        // Método para mostrar informações do veículo
        public virtual void Mostrar()
        {
            Console.WriteLine($"Tipo do veículo: {Tipo}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Ano: {Ano}");
        }
    }
}
