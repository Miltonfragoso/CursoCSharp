/*
 * Nesta aula, vamos usar uma sobrecarga do metodo Sort(). Lembrando que o metodo Sort() é usado para ordenar lista e usa a interface IComparable.
 * 
 * Entretanto, desta forma nossa classe Product não fica fechada
    para alteração: se o critério de comparação mudar,
    precisaremos alterar a classe Product.

    Podemos então usar outra sobrecarga do método "Sort" da
    classe List:
    public void Sort(Comparison<T> comparison)

    onde Comparison<T> é um delegate que recebe dois parâmetros do tipo T
    e retorna um int
 */
