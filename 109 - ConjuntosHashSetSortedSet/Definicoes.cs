/*      HashSet<T> e SortedSet<T>
        • Representam um conjunto de elementos (similar ao da Álgebra)
        • Não admite repetições
        • Elementos não possuem posição
        • Acesso, inserção e remoção de elementos são rápidos
        • Oferece operações eficientes de conjunto: interseção, união, diferença.

        Diferenças
        • HashSet
        • Armazenamento em tabela hash
        • Extremamente rápido: inserção, remoção e busca O(1)
        • A ordem dos elementos não é garantida

        • SortedSet
        • Armazenamento em árvore
        • Rápido: inserção, remoção e busca O(log(n))
        • Os elementos são armazenados ordenadamente conforme implementação
        IComparer<T>



        Alguns métodos importantes
        • Add
        • Clear
        • Contains
        • UnionWith(other) - operação união: adiciona no conjunto os elementos do
        outro conjunto, sem repetição
        • IntersectWith(other) - operação interseção: remove do conjunto os
        elementos não contidos em other
        • ExceptWith(other) - operação diferença: remove do conjunto os elementos
        contidos em other
        • Remove(T)
        • RemoveWhere(predicate)


 */
