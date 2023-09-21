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

<a href="https://github.com/users/MateusMaceedo/projects/1/views/1">
   <img src="https://github.com/MateusMaceedo/Impulsionatech-Gerenciador-Contas/blob/feature/MigracaoDotnet6/img/MultiContas-Cloud-Native-Decision-Log.png?raw=true" alt="multi-contas logo" title="multiContasContainers" align="center" />
</a>

 🚨 *Clique na imagem acima para ver ler sobre as decisões técncias do projeto*

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

**Cenário 1: Requisições Simples de Leitura (GET)**

- Objetivo: Medir o desempenho básico da API ao lidar com solicitações de leitura simples.

- Cenário:
  - Realize um teste de carga com um número crescente de solicitações GET.
  - Comece com 10 usuários virtuais e aumente gradualmente até atingir 100, 500, 1000, etc.
  - Registre o TPS (Transações Por Segundo) e o RPS (Requisições Por Segundo) em cada nível de carga.
  - Meça o tempo de resposta médio.

**Cenário 2: Requisições de Gravação (POST/GET)**

- Objetivo: Avaliar o desempenho da API ao lidar com solicitações de gravação, como POST e GET.

- Cenário:
  - Realize um teste de carga com solicitações de gravação (por exemplo, POST para criar recursos).
  - Varie a carga de trabalho com diferentes tamanhos de carga (número de solicitações de gravação por segundo).
  - Registre o TPS, RPS e tempo de resposta médio.
  - Avalie a latência da API.

**Cenário 3: Autenticação e Autorização**

- Objetivo: Avaliar o desempenho da API quando há autenticação e autorização envolvidas.

- Cenário:
  - Realize um teste de carga que inclua solicitações autenticadas.
  - Varie a carga de trabalho com diferentes perfis de usuário (por exemplo, usuários autenticados vs. não autenticados).
  - Registre o TPS, RPS e tempo de resposta médio para cada perfil.
  - Avalie como a autenticação afeta o desempenho.

**Cenário 4: Testes de Estresse**

- Objetivo: Avaliar como a API se comporta sob cargas de trabalho extremas.

- Cenário:
  - Realize um teste de estresse aumentando a carga até que o sistema atinja um estado de degradação.
  - Registre o TPS, RPS, tempo de resposta médio e erros.
  - Identifique o ponto em que o sistema começa a degradar o desempenho.

**Cenário 5: Testes de Longa Duração**

- Objetivo: Avaliar como a API se comporta em cargas de trabalho sustentadas ao longo do tempo.

- Cenário:
  - Realize testes de longa duração que simulem um uso contínuo da API.
  - Registre métricas de desempenho ao longo do tempo, incluindo TPS, RPS e uso de recursos (CPU, memória, etc.).

**Cenário 6: Testes de Pico**

- Objetivo: Avaliar como a API lida com picos repentinos de tráfego.

- Cenário:
  - Realize testes que simulem picos de tráfego repentinos.
  - Registre o tempo de resposta, TPS e RPS durante os picos.
  - Avalie se a API é escalável para atender aos picos de demanda.
