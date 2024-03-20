# Fundamentos de APIs em ASP.NET Core

Este é um projeto desenvolvido como parte do curso "Fundamentos de APIs em ASP.NET Core" na plataforma desenvolvedor.io . Durante este curso, adquiri conhecimento sobre o funcionamento das APIs, todas as funcionalidades essenciais, bem como tópicos avançados, incluindo configuração do Entity Framework, mapeamento de banco de dados com Migrations, validação de entidades e segurança da API, incluindo autenticação e autorização com ASP.NET Identity e uso de JWT (JSON Web Tokens) para autenticar e autorizar a API. O projeto foi construído seguindo as melhores práticas de desenvolvimento.

## Descrição do Projeto

Este projeto é uma aplicação API desenvolvida em ASP.NET Core. Ele demonstra os seguintes tópicos:

- Estrutura de uma API: A aplicação segue as práticas recomendadas para criar uma API RESTful, incluindo a definição de rotas, controladores e endpoints.
- Entity Framework e Migrations: Utilizamos o Entity Framework Core para mapear e interagir com o banco de dados, com suporte a migrações para manter o esquema do banco de dados atualizado.
- Validação de Entidades: Implementamos validações para garantir a integridade dos dados recebidos pela API.
- Segurança da API: Adicionamos autenticação e autorização à API usando ASP.NET Identity e JWT, garantindo que apenas usuários autenticados e autorizados possam acessar recursos protegidos.
- Boas Práticas: O código-fonte do projeto segue as melhores práticas de desenvolvimento para manter o código limpo, organizado e escalável.

## Pré-requisitos

Antes de executar este projeto, certifique-se de ter as seguintes ferramentas e recursos disponíveis:

- Visual Studio (ou Visual Studio Code) com suporte ao desenvolvimento ASP.NET Core.
- .NET SDK
- SQL Server (ou outro banco de dados compatível)
- Navegador da Web

## Configuração e Uso

1. Clone este repositório em sua máquina local.
2. Abra o projeto no Visual Studio (ou Visual Studio Code).
3. Configure a conexão com o banco de dados no arquivo de configuração apropriado.
4. Execute as migrações para criar ou atualizar o banco de dados:

```bash
dotnet ef database update
```

5. Execute a aplicação:

```bash
dotnet run
```

6. Acesse a API por meio de um cliente REST (como o Postman) ou um navegador da web para testar os endpoints.

## Contato

Se você tiver alguma dúvida ou sugestão, sinta-se à vontade para entrar em contato:

Matheus Fernandes - [matheusfernandesofc@gmail.com](mailto:matheusfernandesofc@gmail.com)

Projeto: [Link para o Projeto no GitHub](https://github.com/cafepng/ApiFuncional)
