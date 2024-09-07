namespace Veiculos.Entidades.Servicos
{
    public interface ISeguro
    {
        void SeguroParticular();
    }
    
    public class SeguroCarro : ISeguro
    {
        public void SeguroParticular()
        {
            System.Console.WriteLine("Seguro particular para carros");
        }
    }
}
