using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo!");

            Produtos produto = new Produtos();

            Console.WriteLine("Informe o codigo do produto..........");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Nome do produto............");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Informe o Preço do produto...........");
            produto.Preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade do produto .....");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto");
            Console.WriteLine("Código............."+produto.Codigo);
            Console.WriteLine("Nome..............."+produto.Nome);
            Console.WriteLine("Preço.............."+produto.Preco);
            Console.WriteLine("Quantidade........."+produto.Quantidade);
            
            
            Console.ReadKey();
        }
    }
}
