using System;

/*Classe sealed: evita que a clase seja herdada
 * Nota: ainda é possível extender a funcionalidade de uma classe selada usando
 * "extension methods"
 * 
 * 
 * 
 * 
 * Método sealed: evita que um método sobreposto possa ser sobreposto novamente. Só pode ser aplicado a métodos sobrepostos
 * 
 * 
 * 
 * 
 * Pra quê?
   Segurança: dependendo das regras do negócio, às vezes é desejável
   garantir que uma classe não seja herdada, ou que um método não
   seja sobreposto.
   • Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas
     podem ser uma porta de entrada para inconsistências
   • Performance: atributos de tipo de uma classe selada são analisados
     de forma mais rápida em tempo de execução.
   • Exemplo clássico: string
 */



namespace ClassesMetodosSelados
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
