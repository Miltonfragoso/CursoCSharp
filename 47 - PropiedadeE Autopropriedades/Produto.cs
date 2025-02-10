using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PropiedadeE_Autopropriedades
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        // implementação de uma propiedade
        // value é o nome que vem do parametro
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get
            {
                return _preco;
            }
            set
            {
                _preco = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
            set
            {
                _quantidade = value;
            }
        }


        //Auto propriedade
        //private string _nome;
        //private double _preco { get; private set;};
        //private int _quantidade { get; private set; };

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
