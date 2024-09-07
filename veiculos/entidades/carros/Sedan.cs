namespace Veiculos.Entidades.Carros
{
    public class Sedan : Carro
    {
        public Sedan(string marca, string modelo) : base(marca, modelo, "Sedan") { }

        public override void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine("Tipo: Sedan");
        }
    }
}