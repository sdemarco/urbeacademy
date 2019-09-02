namespace DependencyInjection
{
    public interface ISerVivo
    {
        string Nombre { get; set; }
        bool Comer(IAlimento alimento);
    }
}
