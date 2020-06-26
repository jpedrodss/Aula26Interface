namespace Aula26Interface
{
    public interface ICarrinho
    {
         void Ler();
         void Incluir(Produto _produto);
         void Excluir(Produto _produto);
         void Alterar(int _cod, Produto produto);
         void MostrarTotal();
    }
}