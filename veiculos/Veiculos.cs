namespace Veiculos.Entidades.Carros
{
    public class Veiculo
    {
        private string marca;
        private string modelo;

        public Veiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public virtual void Mostrar()
        {
            System.Console.WriteLine($"Marca: {marca}, Modelo: {modelo}");
        }
    }
}
