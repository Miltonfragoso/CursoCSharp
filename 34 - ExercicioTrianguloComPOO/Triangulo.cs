/*CLASS 
 *É um tipo estruturado que pode conter(membros):
 *Atributos(dados/campos)
 *Métodos(funções/operações)
 *
 *
 *A CLASS também pode prover muitos outros recursos, tais como:
 *Construtores
 *Sobrecarga
 *Encapsulamento
 *Herança
 *Polimorfismo
 *
 *
 *A CLASS é o fundamento principal da POO ela representar:
     *Entidades: Produto, Cliente, Triangulo
    *Serviços: ProdutoService, ClienteService, EmailService, StorageService
    *Controladores: ProdutoController, ClienteController
    *Utilitários: Calculadora, Compactador
    *Outros (views, repositórios, gerenciadores, etc.)
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioTrianguloComPOO
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;


        /*O método é uma função dentro da class
         * Com o método evitamos a repetição do código
         * Quando o método esta na mesma class não precisa passar parametro*/

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
