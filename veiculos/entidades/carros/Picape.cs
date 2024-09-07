namespace Veiculos.Entidades.Carros
{
    public class Picape : Carro
    {
        public Picape(string marca, string modelo) : base(marca, modelo, "Picape") { }

        public override void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine("Tipo: Picape");
        }
    }
}