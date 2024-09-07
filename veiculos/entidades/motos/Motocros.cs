namespace Veiculos.Entidades.Motos
{
    public class Motocross : Moto
    {
        public Motocross(string marca, string modelo) : base(marca, modelo, "Motocross") { }

        public override void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine("Tipo: Motocross");
        }
    }

}
