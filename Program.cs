using System;

namespace Aula26Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Dark Souls Remastered", 129.90f);
            Produto p2 = new Produto(2, "Dark Souls II: Scholar of The First Sin", 89.90f);
            Produto p3 = new Produto(3, "Dark Souls III: Deluxe Edition", 149.90f);

            Carrinho cart = new Carrinho();

            cart.Incluir(p1);
            cart.Incluir(p2);
            cart.Incluir(p3);

            cart.Ler();

            cart.Excluir(p2);
            System.Console.WriteLine($"{p2.Nome} removido do carrinho. O melhor dark souls é o 3");

            cart.Ler();
            
            cart.MostrarTotal();
        }
    }
}
