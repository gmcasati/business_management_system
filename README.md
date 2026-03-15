# Business Management System

## Visão Geral

O **Business Management System** é uma aplicação backend protótipo desenvolvida para gerenciar informações estruturadas sobre empreendimentos e empreendedores localizados no estado de Santa Catarina, Brasil. O projeto foi desenvolvido como parte de um desafio técnico para o **edital IA para Desenvolvedores organizado pela SCTech**, com o objetivo de demonstrar a implementação de um serviço simples, porém bem estruturado, para gestão de dados relacionados ao empreendedorismo.

Santa Catarina destaca-se nacionalmente pelo seu forte ecossistema empreendedor, com grande presença de micro e pequenas empresas, startups e iniciativas voltadas à inovação e ao desenvolvimento econômico. Este projeto simula um sistema capaz de organizar e gerenciar informações sobre esses empreendimentos, permitindo o cadastro, consulta, manutenção e gestão dos registros de forma estruturada.

O principal objetivo deste repositório é apresentar uma arquitetura clara e organizada, além de uma API REST capaz de lidar com as operações básicas necessárias para um sistema de registro de empreendimentos.

## Funcionalidades

O sistema oferece um conjunto de funcionalidades essenciais para a gestão de empreendimentos:

- Cadastro de novos empreendimentos
- Listagem de todos os empreendimentos cadastrados
- Consulta de detalhes de um empreendimento específico
- Atualização das informações de um empreendimento
- Remoção de um empreendimento do sistema

Cada registro de empreendimento contém informações estruturadas como:

- Nome do empreendimento
- Nome do empreendedor responsável
- Município de Santa Catarina
- Segmento de atuação (Tecnologia, Comércio, Indústria, Serviços, Agronegócio)
- E-mail ou meio de contato
- Status (Ativo ou Inativo)

Essas funcionalidades demonstram a implementação de um fluxo completo de **CRUD**, exposto através de endpoints REST.

## Arquitetura

O projeto segue uma **arquitetura em camadas**, separando responsabilidades para melhorar a manutenibilidade, testabilidade e escalabilidade da aplicação.

### Camada de Domínio

A camada de domínio define o modelo central da aplicação. Nela está definida a entidade **Business (Empreendimento)**, que representa um empreendimento cadastrado no sistema. Também são definidos os contratos de repositório responsáveis por descrever as operações de persistência e recuperação de dados.

### Camada de Infraestrutura

A camada de infraestrutura implementa os detalhes de persistência de dados utilizando **Entity Framework Core** como ORM. Para fins de protótipo e simplificação da execução do projeto, está sendo utilizado o **provider InMemory**, permitindo que a aplicação funcione sem necessidade de configuração de um banco de dados externo.

Nesta camada também são implementados os repositórios responsáveis por interagir com o mecanismo de armazenamento de dados.

### Camada de API

A camada de API expõe as funcionalidades da aplicação por meio de endpoints RESTful. A aplicação disponibiliza endpoints para criação, consulta, atualização e remoção de empreendimentos.

O projeto também inclui documentação automática da API utilizando **Swagger / OpenAPI**, permitindo que os endpoints sejam facilmente visualizados e testados por desenvolvedores.

## Endpoints da API

A aplicação disponibiliza os seguintes endpoints:

- `POST /api/businesses` – Criação de um novo empreendimento  
- `GET /api/businesses` – Listagem de todos os empreendimentos  
- `GET /api/businesses/{id}` – Consulta dos detalhes de um empreendimento  
- `PUT /api/businesses/{id}` – Atualização de um empreendimento existente  
- `DELETE /api/businesses/{id}` – Remoção de um empreendimento  

## Tecnologias Utilizadas

O projeto utiliza tecnologias modernas para desenvolvimento de APIs backend:

- .NET
- ASP.NET Core Web API
- Entity Framework Core
- InMemory Database Provider
- Swagger / OpenAPI
- Princípios de API REST

## Objetivos do Projeto

Este projeto busca demonstrar:

- Estruturação clara de um projeto backend
- Separação de responsabilidades entre camadas
- Modelagem de domínio básica
- Implementação de APIs REST
- Uso do padrão Repository
- Boas práticas iniciais de desenvolvimento backend

Embora seja um protótipo, a estrutura da aplicação foi projetada de forma a permitir evoluções futuras, como persistência em banco de dados relacional, inclusão de autenticação, filtros de consulta e integração com outros serviços.

## Melhorias Futuras

Algumas melhorias possíveis para evolução do projeto incluem:

- Integração com banco de dados persistente (SQL Server ou PostgreSQL)
- Implementação de filtros por município ou setor de atuação
- Paginação e busca de registros
- Validação mais robusta dos dados de entrada
- Testes automatizados (unitários e de integração)
- Containerização da aplicação com Docker

## Licença

Este projeto está disponível sob a licença **MIT**.
