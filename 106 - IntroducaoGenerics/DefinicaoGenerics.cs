/*
 * Generics
    • Generics permitem que classes, interfaces e métodos possam ser
    parametrizados por tipo. Seus benefícios são:
    • Reuso
    • Type safety
    • Performance

    * Uso comum: coleções
    List<string> list = new List<string>();
    list.Add("Maria");
    string name = list[0];

No C#, Generics (ou genéricos) são um recurso que permite criar classes, interfaces, métodos e estruturas reutilizáveis, 
que funcionam com tipos diferentes, sem precisar duplicar código e mantendo segurança de tipos (type safety).

Em outras palavras:

Generics permitem que você escreva um código só, mas que funcione com qualquer tipo (int, string, objetos, etc.), 
sem precisar fazer casting e evitando repetição.
Para garantir que o código funcione corretamente usamos o parâmetro de tipo, que é representado por uma letra maiúscula (T, U, V, etc.)
O T é uma convenção que significa "Type" (Tipo), mas você pode usar qualquer letra ou nome que faça sentido no contexto.
tambem podemos restrigir o tipo que pode ser usado com o generic usando constraints (restrições).como exemplo, 
podemos dizer que T deve ser uma classe, uma struct, ou implementar uma interface específica.

where T : struct → apenas tipos de valor (ex: int, DateTime)

where T : class → apenas tipos de referência

where T : new() → deve ter construtor sem parâmetros

where T : MinhaClasseBase → deve herdar de MinhaClasseBase

where T : IMinhaInterface → deve implementar a interface
 */
