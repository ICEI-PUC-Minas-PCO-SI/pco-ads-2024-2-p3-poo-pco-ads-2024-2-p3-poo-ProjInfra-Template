// Classe derivada Carro
namespace com.aluno.veiculos.entidades.veiculos
{
public class Carro : Veiculo
{
    private int anoModelo { get; set; }

    public Carro(string tipo, string marca, string modelo, string cor, int ano, int anoModelo) : base(tipo, marca, modelo, cor, ano)
    {
        this.anoModelo = anoModelo;
    }

    // sobreescreve o metodo mostrar
    public override void Mostrar()
    {
        
        Console.WriteLine($"Tipo do veículo: {Tipo}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Ano do modelo: {anoModelo}"); //-- Substitui o ano da classe base
    }

    public void SeguroParticular()
    {
        Console.WriteLine("Sem seguro.");
    }

}}