using com.aluno.veiculos.entidades.servicos;

namespace com.aluno.veiculos.entidades.veiculos
{
    public class Sedan : Carro
    {
        // Atributo que sera de acordo com o objeto
        private bool disponivel { get; set; }

        // Construtor
        public Sedan(string tipo, string marca, string modelo, string cor, int ano, int anoModelo, bool disponivel): base(tipo, marca, modelo, cor, ano, anoModelo)
        {
            this.disponivel = disponivel;
        }

         // sobreescreve o metodo mostrar
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Carro esta disponviel?: {(disponivel ? "Sim" : "Não")}");
        }

        // Seguro do objeto
        public new void SeguroParticular()
        {
            Console.WriteLine("Seguro particular disponivel!! Valor adicional de R$ 150,00 somados as parcelas.");
        }
    }
}
