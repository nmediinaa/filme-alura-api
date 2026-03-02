# Filmes API

> Personal project focused on building RESTful APIs using .NET 6, based on Alura's coursework.

![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Swagger](https://img.shields.io/badge/-Swagger-%23Clojure?style=for-the-badge&logo=swagger&logoColor=white)

## 📖 Sobre o Projeto
Esta é uma API RESTful desenvolvida durante o curso de web em .NET 6 API da Alura. O projeto foca em boas práticas de backend, persistência de dados com Entity Framework e documentação interativa.

## 🔍 Documentação com Swagger

A API está documentada utilizando o Swagger. Lá você pode visualizar todos os endpoints, os esquemas de dados (Models) e testar as requisições direto pelo navegador.

<img width="1323" height="609" alt="image" src="https://github.com/user-attachments/assets/83c9847d-3a20-440f-abd2-516ab37c4f90" />

## 🛣️ Principais Endpoints

Aqui está um resumo das rotas disponíveis:

| Método | Endpoint | Descrição |
| :--- | :--- | :--- |
| `GET` | `/api/filme` | Retorna a lista de todos os filmes. |
| `GET` | `/api/filme/{id}` | Busca um filme específico pelo seu ID. |
| `POST` | `/api/filme` | Adiciona um novo filme ao catálogo. |
| `PUT` | `/api/filme/{id}` | Atualiza os dados de um filme existente. |
| `PATCH` | `/api/filme/{id}` | Atualiza dados especificos de um filme existente. |
| `DELETE` | `/api/filme/{id}` | Remove um filme do banco de dados. |
