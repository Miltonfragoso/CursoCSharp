/*                                             DESALOCAÇÃO POR GARBAGE COLLETOR
 * Garbage colletor é um processo que gerencia a memoria de um programa em execução, ele monitora os objetos alocados dinamicamente pelo programa na memória 
 * HEAP, DESALOCANDO AQUELES OBJETOS QUE NÃO ESTÃO MAIS SENDO UTILIZADOS.
 * 
 * QUANDO NÃO TIVER MAIS UMA CAIXA NA STACK APONTANDO PARA UM OBJETO NA HEAP QUE INICIALMENTE TINHA ALGUEM REFERENCIANDO ESSE OBJETO NA HEAP, APARTIR DO 
 * MOMENTO QUE NÃO TIVER MAIS NINGUEM APONTANDO PARA ELA, SEM REFERENCIA, AI ESSE OBJETO É DESALOCADO DA HEAP PELO GARBAGE COLLETOR.
 * 
 * O GARBAGE FUNCIONA PARA OS TIPOS REFERENCIA.
 * 
 * EX:   e se p2 receber o número de memoria de p1?
 *       E se p2 = p1? R: p2 VAI PASSAR A TER O MESMO NÚMERO DA MEMORIA DA HEAP E VAI DEIXAR DE APONTAR PARA O OBJETO NA QUAL ESTAVA APONTANDO E PASSARA 
 *       A APONTAR TAMBÉM PARA ONDE P1 APONTA, O OBJETO NA QUAL P2 APONTAVA E DESALOCADO PELO GARBAGE.
 *       
 *       
 *       
 * ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 * 
 * 
 * 
 *                                               DESALOCAÇÃO POR ESCOPO
 *              QUANDO ENTRAMOS EM UM ESCOPO POR EXEMPLO IF(CONDIÇÃO){ FAÇA } QUANDO ESTIVER EXECUTANDO O FAÇA É ALOCADO AS VARIAVEIS DO FAÇA NA STACK
 *              E QUANDO SAIR DO FAÇA, AS VARIÁVEIS SÃO APAGADAS. 
 *-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 *
                                     *Resumo
                                    • Objetos alocados dinamicamente, quando não possuem mais
                                    referência para eles, serão desalocados pelo garbage collector

                                    • Variáveis locais são desalocadas imediatamente assim que seu escopo
                                    local sai de execução
 */

using System;

namespace DesalocacaoDeMemoriaGarbageEscopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
