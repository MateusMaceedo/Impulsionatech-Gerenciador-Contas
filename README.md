O que é o projeto Multi-Contas?
=====================
O Multi-Contas é um projeto de código aberto escrito em .NET Core

O objetivo deste projeto é implementar as tecnologias mais utilizadas e compartilhar com a comunidade técnica a melhor forma de desenvolver grandes aplicações com .NET

Comandos dotnet para criar o projeto:

Seguir a documentação: https://www.macoratti.net/19/10/net_climp1.htm

## Dê uma estrela! :estrela:
Se você gostou do projeto ou se o contas te ajudou, dê uma estrela ;)

## Como usar:
- Você precisará do Visual Studio 2022 mais recente e do .NET Core SDK mais recente.
- ***Verifique se você instalou a mesma versão de tempo de execução (SDK) descrita em global.json***
- O SDK e as ferramentas mais recentes podem ser baixados em https://dot.net/core.

Além disso, você pode executar o Contas no Visual Studio Code (Windows, Linux ou MacOS).

Para saber mais sobre como configurar seu ambiente visite o [Microsoft .NET Download Guide](https://www.microsoft.com/net/download)

## Tecnologias implementadas:

- ASP.NET 6.0
 - ASP.NET MVC Core
 - ASP.NET WebApi Core with JWT Bearer Authentication
 - ASP.NET Identity Core
- Entity Framework Core 6.0
- .NET Core Native DI
- AutoMapper
- FluentValidator
- MediatR
- RabbitMQ
- Swagger UI with JWT support
- .NET DevPack
- .NET DevPack.Identity

## Arquitetura:

- Arquitetura completa com preocupações de separação de responsabilidade, SOLID e Clean Code
- Domain Driven Design (Layers and Domain Model Pattern)
- Domain Events
- Domain Notification
- Domain Validations
- CQRS (Imediate Consistency)
- Event Sourcing
- Unit of Work
- Repository

## Fluxo AWS
>Nota: Esse foi o desenho inicial da solução, incialmente foi construido somente com dois MS, dividindo a responsabilidade entre camadas, aos poucos estou realizando um refactor no projeto, incluindo novas praticas e formas diferente, de se trabalhar com desenvolvimento de DevOps em projetos reais.
<h1 align="center">
  <img src="https://github.com/MateusMaceedo/Impulsionatech-Gerenciador-Contas/blob/feature/MigracaoDotnet6/img/Fluxo%20contas%20bancarias.drawio.png?raw=true">
</h1>

## Entendendo os serviços e fluxo atual
<h1 align="center">
  <img src="https://github.com/MateusMaceedo/Impulsionatech-Gerenciador-Contas/blob/feature/MigracaoDotnet6/img/Fluxo%20Multi%20Contas.drawio.png?raw=true">
</h1>

## Noticias
- Ainda em fase de migração de tecnologias e implementações das mesmas.

**v1.0 - 30/12/2022**
- Migrado para .NET 6.0
- Todas as dependências estão atualizadas

## Isenção de responsabilidade:
- **NÃO** pretende ser uma solução definitiva
- Cuidado para usar no modo de produção
- Talvez você não precise de muitas implementações incluídas, tente evitar o **excesso de engenharia**

## Pull-Requests
Faça um contato! Não envie PRs para recursos extras, todos os novos recursos estão planejados

## 👨🏻‍🚀 Sobre mim
<a href="https://www.linkedin.com/in/mateus-macedo-937a32163/">
 <img style="border-radius:50%" width="100px; "src="https://avatars.githubusercontent.com/u/63172367?s=460&u=11fd26ea8a7f5663d7707d7ef254e4f8bfca1b05&v=4"/>
 <p>Mateus Macedo</p>
</a>
