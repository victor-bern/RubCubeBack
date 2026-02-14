# ROADMAP

## ✅ Histórias atendidas e como foram implementadas

- **Configuração do Ambiente:** Estruturação do projeto e suporte para execução local e via Docker.
  - Criação da solução Web API em ASP.NET 10 com suporte a Docker (Dockerfile).
- **Persistência e Migrations:** Implementação das camadas de Infraestrutura e Domínio.
  - Criação da biblioteca de classes `RubCubeBack.Infra`, contendo o `DbContext` e métodos de extensão para configuração de inicialização.
  - Definição da camada de Domínio com as entidades `User`, `Log` e `MetalPriceSymbol`.
  - Geração e aplicação de Migrations para versionamento do esquema do banco de dados.
  - Implementação de extensão para automação de banco de dados, incluindo o método `RunMigrate()` para aplicar migrações pendentes no startup da aplicação.
- **Injeção de Dependências:** Centralização do registro de serviços para suporte à Inversão de Controle (IoC).
- **CRUD de Usuários:** Implementação de Repositórios, Serviços e Controllers.
  - Estruturação da camada de Aplicação contendo serviços, exceções personalizadas e validadores.
  - Integração da biblioteca **FluentValidation** para validação de entrada de dados.
  - Implementação do Repositório de Usuários com operações de CRUD e persistência via `DbContext`.
  - Desenvolvimento da camada de serviço com lógica de pré-persistência, incluindo filtros de busca e criptografia (hashing) de senhas.
  - Modelagem de DTOs para Requisição, Resposta e Filtros, garantindo o desacoplamento das entidades.
  - Implementação de validadores fluentes para as requisições de usuário.
  - Exposição de endpoints via `UserController`: `GetUsers`, `CreateUser`, `UpdateUser` e `DeleteUser`.
- **Autenticação (JWT):** Implementação de segurança e controle de acesso.
  - Integração e configuração do suporte nativo ao **JWT** (JSON Web Token) no ASP.NET.
  - Configuração da autenticação na camada de Infraestrutura, utilizando *Claims* customizadas (Nome, E-mail e ID).
  - Desenvolvimento de serviço para geração de tokens por usuário.
  - Implementação de política de autorização global (`[Authorize]`), exceto para a rota de criação de usuários.
  - Criação do `AuthController` para validação de credenciais e emissão de tokens de acesso.
- **Auditoria e Logs:** Middleware e persistência de registros de requisições.
  - Implementação de Repositório de Logs para persistência e consultas filtradas.
  - Configuração do **Serilog** com *sink* para o banco de dados, incluindo mapeamento de colunas customizadas.
  - Desenvolvimento de Middleware para interceptação de requisições e log assíncrono, garantindo que o rastreio não onere a thread principal de execução.
  - Exposição de API para consulta e filtragem de logs de auditoria.
- **Integração MetalPrice API:** Consumo de serviços externos e tratamento de dados.
  - Implementação de um cliente HTTP customizado para integração com a API MetalPrice.
  - Desenvolvimento de serviço de domínio para processamento de símbolos e moedas com filtros personalizados.
  - Implementação de *Seeding* de dados para os símbolos da MetalPrice, reduzindo a latência e o custo de chamadas externas.
  - Exposição de rotas em `CoinController` para listagem de símbolos disponíveis e consulta de cotações filtradas.
- **Otimização com Cache (Redis):** Estratégia de cacheamento para dados externos.
  - Integração e configuração do **Redis** ao ecossistema da aplicação.
  - Implementação de política de expiração de cache (TTL) de 1 hora para dados de mercado.
  - Desenvolvimento de serviço de abstração para operações de cache (Get/Set).
  - Implementação do padrão *Cache-Aside* na busca de moedas: o sistema consulta o Redis antes de realizar chamadas à API externa, persistindo novos resultados automaticamente.
- **Otimização do Ambiente Docker**: Aprimorar a execução e a orquestração do projeto via containers.
  - Implementação de um arquivo `docker-compose` contendo os serviços de Redis e PostgreSQL, simplificando o processo de inicialização e configuração do ambiente para novos desenvolvedores.

## ⏳ O que faria se tivesse mais tempo

- Cobertura de testes automatizados: unit tests para Domain e Application; testes de integração para Infra.

---

## 🚀 Melhorias e otimizações que gostaria de adicionar

- **Implementação de Testes End-to-End (E2E)**: Desenvolvimento de testes integrados utilizando um banco de dados real para validar o fluxo completo da aplicação.

---

