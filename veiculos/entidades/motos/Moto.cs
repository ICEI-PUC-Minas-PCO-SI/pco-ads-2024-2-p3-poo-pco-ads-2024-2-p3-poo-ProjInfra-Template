namespace Veiculos.Entidades.Motos
{
    public class Moto : Veiculos.Entidades.Carros.Veiculo
    {
        private string tipoMoto;

        public Moto(string marca, string modelo, string tipoMoto) : base(marca, modelo)
        {
            this.tipoMoto = tipoMoto;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine($"Tipo de Moto: {tipoMoto}");
        }
    }
}
