using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PalavraThis
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }


        //Sobrecarga e reaproveitando o construtor padrão no construtor de 2 argumentos usando o : this 
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        //Sobrecarga e reaproveitando o construtor de 2 argumentos no construtor de 3 argumentos usando o : this 
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }


        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;

        }


        public void RemoverProdutos(int quanuantidade)
        {
            Quantidade -= quanuantidade;

        }


        //Toda CLASS em c# é uma subclass de Object que possui os seguintes métodos: GetType, Equals, GetHasCode e ToString que converte o objeto para string
        //Esse método ToString foi criado para evitar a repetição de código visto que será imprsso a saída de dados por três vezes
        // função que permite converter o objeto para string no nosso caso criando uma concatenação de string
        // O override cria uma sobreposição da class que é uma subclass de object.
        public override string ToString()
        {
            return Nome
                   + ", $ "
                   + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + Quantidade
                   + " unidades, Valor Total em estoque:  $ "
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
