/*
 * ✅ Para que serve uma interface no C#?

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



✅ Função da herança com classe abstrata

Fornecer um modelo comum

Você cria uma "forma geral" de algo, mas deixa os detalhes para as subclasses.

Exemplo: Animal é genérico, mas Cachorro e Gato implementam comportamentos específicos.

Obrigar implementação de métodos

Métodos abstratos devem ser implementados nas classes filhas.

Isso garante consistência entre diferentes tipos.

Reutilizar código

A classe abstrata pode conter métodos/propriedades já implementados, que as subclasses herdam automaticamente.

Evita repetição de código.

Aplicar polimorfismo

Você pode tratar diferentes subclasses como se fossem do tipo abstrato.

Exemplo: uma lista de Animal pode conter Cachorro, Gato, Leão etc.















 */
