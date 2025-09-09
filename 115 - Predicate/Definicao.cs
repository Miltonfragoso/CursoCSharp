/*
 * Predicate - Definição: É um delegate que representa um método que recebe um parâmetro de entrada e retorna um valor booleano (true ou false).
 * public delegate bool Predicate<in T>(T obj);
 * 
 * Em C#, Predicate = um delegado que retorna bool.

    Usado para verificar condições sobre objetos.

    Muito usado em List<T> (Find, Exists, RemoveAll, etc.).

    É basicamente o mesmo que Func<T, bool>

    Usando em listas (List<T>)

    A classe List<T> tem vários métodos que usam Predicate<T>:

    Find(Predicate<T>) → retorna o primeiro elemento que satisfaz a condição

    FindAll(Predicate<T>) → retorna todos os elementos que satisfazem a condição

    Exists(Predicate<T>) → retorna true/false se algum satisfaz

    RemoveAll(Predicate<T>) → remove todos que satisfazem

    TrueForAll(Predicate<T>) → retorna true se todos satisfazem
 */
