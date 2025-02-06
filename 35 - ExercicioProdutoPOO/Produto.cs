/*----------------------------------------------------------------------------------------------------------------------
  Toda classe em c# é uma sublasse da classe Object
  A classe Obect possui os seguintes métodos:
  *GetType - retorna o tipo do objeto
  * Equals - compara se o objeto é igual a outro
  * GetHasCode - retorna um código hash do objeto
  * Tostring - converte o objeto ou a classe nesse caso Produto para uma string
   Ao implementarmos o método Tostring em nossa classe podemos definir como esse objeto é representao na forma de string
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioProdutoPOO
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        /*Variável de entrada de função sempre com letra minuscula
         este método tem como função receber um valor e soma-lo a quantidade*/
        public void AdicionarProdutos(int quatidade)
        {
            Quantidade = Quantidade + quatidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }


        /*Implementação do método Tostring, por ser método de outra classe precisamos fazer uma sobreposição
         a palavra override indica uma sobreposição
        MÉTODO PARA PERSONALIZARA SAÍDA DE DADOS*/

        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
