namespace Veiculos.Entidades.Carros
{
    public class Carro : Veiculo
    {
        private string tipoCarro;

        public Carro(string marca, string modelo, string tipoCarro) : base(marca, modelo)
        {
            this.tipoCarro = tipoCarro;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine($"Tipo de Carro: {tipoCarro}");
        }

        public void ContratarSeguro()
        {
            System.Console.WriteLine("Seguro contratado.");
        }
    }
}
