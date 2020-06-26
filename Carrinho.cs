using System;
using System.Collections.Generic;

namespace Aula26Interface
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carrinho = new List<Produto>();
        public float ValorTotal { get; set; }
        public void Alterar(int _cod, Produto produtoAlterado){
            carrinho.Find(z => z.Codigo == _cod).Nome = produtoAlterado.Nome;
            carrinho.Find(x => x.Codigo == _cod).Preco = produtoAlterado.Preco;
        }

        public void Incluir(Produto _produto){
            carrinho.Add(_produto);
        }

        public void Excluir(Produto _produto){
            carrinho.Remove(_produto);
            System.Console.WriteLine($"{_produto.Nome} removido do carrinho.");

        }

        public void Ler(){
            System.Console.WriteLine("");
            foreach (Produto item in carrinho){
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.WriteLine($"{item.Nome} - R${item.Preco}.");
                Console.ResetColor();
            }
            System.Console.WriteLine("");
        }
        public void MostrarTotal(){
            foreach (Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            Console.ForegroundColor = System.ConsoleColor.Cyan;
            System.Console.WriteLine($"Valor total de itens: R${ValorTotal}.");
            Console.ResetColor();
            System.Console.WriteLine("");
        }
    }
}