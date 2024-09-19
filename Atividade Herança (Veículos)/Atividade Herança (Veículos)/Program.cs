using com.aluno.veiculos.entidades.veiculos;

class Program
{
    static void Main(string[] args)
    {
        // Carro
        Carro carro1 = new Carro("Carro", "Fiat", "Uno", "Vermelho", 2024, 2024);
        Carro carro2 = new Carro("Carro", "Ford", "Ka", "Azul", 2023, 2023);

        // Sedan
        Sedan sedan1 = new Sedan("Sedan", "Honda", "Civic", "Preto", 2024, 2024, true);
        Sedan sedan2 = new Sedan("Sedan", "Toyota", "Corolla", "Branco", 2023, 2023, false);

        Console.WriteLine("Informações do Carro 1:");
        carro1.Mostrar();
        carro1.SeguroParticular();
        Console.WriteLine();

        Console.WriteLine("Informações do Carro 2:");
        carro2.Mostrar();
        carro2.SeguroParticular();
        Console.WriteLine();

        // Testando Sedan
        Console.WriteLine("Informações do Sedan 1:");
        sedan1.Mostrar();
        sedan1.SeguroParticular();
        Console.WriteLine();

        Console.WriteLine("Informações do Sedan 2:");
        sedan2.Mostrar();
        sedan2.SeguroParticular();
    }
}
