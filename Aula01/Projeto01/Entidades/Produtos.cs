using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    class Produtos
    {
        // atributos (campos)
        private int codigo;
        private string nome;
        private decimal preco;
        private int quantidade;


        //métodos (funções)
        public int Codigo
        {
            set { codigo = value;  }//entrada
            get { return codigo; } // saida
        }

        public string Nome
        {
            set { nome = value; } //entrada
            get { return nome; } //saida 
        }

        public decimal Preco
        {
            set { preco = value;  } //entrada
            get { return preco;  } //saida
        }

        public int Quantidade
        {
            set { quantidade = value; }//entrada
            get { return quantidade; }//saida
        }

        
    }
}
