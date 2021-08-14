# CursoIdiomas


## Sobre
Este repositório consiste em uma Web API utilizando .NET 5.0 e o Design Pattern DDD (Domain-Driven Design) para uma empresa fictícia que oferce cursos de idiomas.

## Versões
- .NET 5.0
- SQL Server 2019 
- SQL Server Management Studio 18

## Como utilizar
Abra o console e navegue até a pasta desejada para clonar o repositório e use:

```
git clone https://github.com/Teuso99/CursoIdiomas.git
```

Depois entre na pasta raiz do projeto e use os seguintes comandos:

```
dotnet restore
```

```
dotnet build
```

Após o build navegue até o diretório **`CursoIdiomas.Application`** e acesse o arquivo **`appsettings.json`**. Nele é possível encontrar a Connection String utilizada:

```json
"ConnectionStrings": {
    "SqlContext": "Server=localhost\\SQLEXPRESS;Database=CursoIdiomas;Trusted_Connection=True;"
  }
```

No campo **`SqlContext`** é necessário substituir a string pela string de conexão a ser utilizada. O SGBD **DEVE SER** SQL Server.

Depois navegue até o diretório **`CursoIdiomas.Infrastructure`** e o comando para atualizar o banco de dados de acordo com as Migrations:

```
dotnet ef --startup-project ..\CursoIdiomas.Application\CursoIdiomas.Application.csproj --project .\CursoIdiomas.Infrastructure.csproj database update
```

Após atualizar o banco navegue até o diretório **`CursoIdiomas.Application`** e execute a API:

```
dotnet run
```

Agora pode acessar a API pelo navegador pela porta que a aplicação estiver escutando, exemplo:

**`localhost:[porta]/swagger/index.html`**

Ao entrar nesse endereço será possível visualizar esta tela:

![Index do Swagger](https://i.imgur.com/yu8STWo.png)

Para realizar a autenticação utilize as rotas de Usuário para registrar um Usuário e Autenticar. O método de Autenticação irá retornar um JWT para ser utilizado na aba Authenticate do Swagger.

![Autenticação pelo Swagger](https://i.imgur.com/jlzhCVL.png)

Nesta aba deve ser informado o token precedido pela palavra Bearer, exemplo: **`Bearer [JWT]`**, onde **[JWT]** é a hash gerada na Autenticação.

Após a autenticação será possível utilizar as outras rotas da API. O JWT expira após **2 HORAS**, depois desse período é necessário gerar outro token.
