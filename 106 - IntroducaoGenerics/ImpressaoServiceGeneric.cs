/*Aqui esta uma solução de um serviço de impressão genérico em C# que pode imprimir listas de qualquer tipo de dado,
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoGenerics
{
    public  class ImpressaoServiceGeneric<T>
    {
        private T[] _valores = new T[10];

        private int _contador = 0;

        public void AddValor(T value)
        {
            if (_contador == 10)
            {
                throw new InvalidOperationException("Limite de valores atingido");
            }

            _valores[_contador] = value;
            _contador++;

        }

        public T Primeiro()
        {
            if (_contador == 0)
            {
                throw new InvalidOperationException("Nenhum valor adicionado");
            }
            return _valores[0];
        }

        public void Imprimir()
        {
            Console.Write("[");
            for (int i = 0; i < _contador - 1; i++)
            {
                Console.Write(_valores[i] + ", ");
            }
            if (_contador > 0)
            {
                Console.Write(_valores[_contador - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
