/*
 O que é a camada de serviços?

A Service Layer (camada de serviços) é responsável por concentrar as regras de negócio da aplicação.

Ela funciona como um intermediário entre:

Camada de apresentação (Controllers, UI, API)

Camada de acesso a dados (Repositories, DbContext, etc.)

🔧 Funções principais da camada de serviços

Centralizar a lógica de negócio

Evita que os controllers ou a camada de dados fiquem com código de regras.

Exemplo: calcular desconto em uma compra ou validar regras antes de salvar um paciente.

Orquestrar operações

Pode chamar múltiplos repositórios ou serviços externos.

Exemplo: ao marcar uma consulta médica, pode precisar verificar agenda, paciente, convênio e gravar tudo de uma vez.

Aplicar validações

Regras que não pertencem ao banco de dados, mas também não devem estar no controller.

Exemplo: “um paciente só pode marcar no máximo 3 consultas no mesmo dia”.

Facilitar testes unitários

Como a regra de negócio está separada em serviços, você consegue testar sem precisar de banco de dados ou controller.

Desacoplamento e reutilização

O mesmo serviço pode ser usado em diferentes partes do sistema (API, console, jobs em background, etc.).
 */
