/*GetHashCode e Equals
    • São operações da classe Object utilizadas para comparar se um objeto
    é igual a outro
    • Equals: lento, resposta 100%
    • GetHashCode: rápido, porém resposta positiva não é 100%
    • Os tipos pré-definidos já possuem implementação para essas
    operações. Classes e structs personalizados precisam sobrepô-las.

O Equals
     E mais lento , mas resposta 100%
    • Verifica se um objeto é igual a outro
    • A implementação padrão compara referências (endereços de memória)
    • Pode ser sobreposto para comparar o conteúdo dos objetos
    • Deve ser reflexivo, simétrico, transitivo e consistente
    • Deve retornar false se o objeto comparado for null

O GetHashCode é mais rápido, porém resposta positiva não é 100%
    • Retorna um valor inteiro (hash code) que representa o objeto
    • Usado em estruturas de dados como tabelas hash (ex: Dictionary)
    • A implementação padrão gera um hash code baseado na referência
    • Deve ser sobreposto para gerar hash codes baseados no conteúdo
    • Se dois objetos são iguais (Equals retorna true), devem ter o mesmo hash code
    • Se dois objetos têm hash codes diferentes, são definitivamente diferentes
    • Dois objetos podem ter o mesmo hash code (colisão), mas não são necessariamente iguais

Resumo: Faz a busca com base no HashCode e depois compara com Equals

 */
