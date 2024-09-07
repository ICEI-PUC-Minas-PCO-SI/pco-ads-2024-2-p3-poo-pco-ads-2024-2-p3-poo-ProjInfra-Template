namespace Veiculos.Entidades.Motos
{
    public class Scooter : Moto
    {
        public Scooter(string marca, string modelo) : base(marca, modelo, "Scooter") { }

        public override void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine("Tipo: Scooter");
        }
    }
}
