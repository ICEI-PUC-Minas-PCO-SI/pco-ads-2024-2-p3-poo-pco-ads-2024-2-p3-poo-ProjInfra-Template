using Veiculos.Entidades.Carros;
using Veiculos.Entidades.Motos;
using Veiculos.Entidades.Servicos;

class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias dos veículos
        Veiculo sedan = new Sedan("Toyota", "Camry");
        Veiculo picape = new Picape("Ford", "Ranger");
        Veiculo motocross = new Motocross("Honda", "CRF");
        Veiculo scooter = new Scooter("Yamaha", "Vino");

        // Aqui ficam os dados dos veículos .-.
        sedan.Mostrar();
        picape.Mostrar();
        motocross.Mostrar();
        scooter.Mostrar();

        ISeguro seguro = new SeguroCarro();
        seguro.SeguroParticular();
    }
}
