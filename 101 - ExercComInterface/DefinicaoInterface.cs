/*
 ✅ Para que serve uma interface no C#?

Definir um contrato comum

Várias classes diferentes podem seguir o mesmo “contrato”.

Ex.: qualquer classe que implemente IAnimal deve ter o método Falar().

Polimorfismo

Permite tratar objetos diferentes de forma igual se eles implementam a mesma interface.

Ex.: você pode ter uma lista de IAnimal contendo Cachorro, Gato, Pato etc.

Separação de responsabilidades

Ajuda a organizar o código e aplicar princípios de design como SOLID (especialmente o I: Interface Segregation Principle).

Facilitar testes

Usando interfaces, você pode simular dependências (com mocks) em testes unitários.

Flexibilidade em arquiteturas

Permite trocar implementações sem quebrar o código.

Ex.: ILogger pode ter várias implementações (ConsoleLogger, FileLogger, DatabaseLogger).
 */
