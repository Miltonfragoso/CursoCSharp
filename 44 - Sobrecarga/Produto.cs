using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sobrecarga
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor padrão permite instanciar da forma normal sem valores (Produto p new Produto());
        public Produto()
        {
            
        }

        /*Este construtor vai obrigar que ao instanciar a classe Produto os valores não podem ser nulos
         terão que ser passados assim que instanciar a classe.*/
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Sobrecarga
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
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
