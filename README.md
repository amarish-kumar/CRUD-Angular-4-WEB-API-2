# Angular 2/4 consumindo ASP.NET Web API 2


## Projeto Angular 2/4

* Angular CLI versão 1.2.0.
* TypeScript 2.3.3.
* Node 8.4.0
* CSS Bootstrap 3.3.7. (ngx-bootstrap)
* Visual Studio Code.

## Projeto ASP.NET Web API 2

 * ASP.NET Web API 2 (C#).
 * Code First com Entity Framework 6.0.0.0.
 * Visual Studio 2017.

### Design Patterns
Service, Dependency Injection, Factory e Repository para divisão de responsabilidades gerando uma arquitetura simples e escalável. 

## Executando o Projeto

* ASP.NET Web API 2.

Abra o projeto no Viusal Studio, depois inicie o console em Tools > NuGet Package Manager > 'Package Manager Console' e 
execute o comando para baixar as dependências. 

```
Update-Package -Reinstall
```

Aguardar a restauração dos pacotes e execute a aplicação.

Atenção: Se o sistema apresentar "403.14 - Forbidden", tudo correu bem, apenas não existe rota para "/".

Sua API já esta ativa e funcional ;) 

* Angular 2/4.

Abra um terminal a partir da pasta do projeto Angular4 e execute seguinte comando para baixar as dependências.

```
npm install
```

IMPORTANTE: Após a restauração dos pacotes acessar o arquivo 'product.service.ts' em 'Angular4\src\app\model' para 
alteração do host da API.

Após alteração do host executar o seguinte comando para iniciar a aplicação.

```
ng server
```

Acessar o endereço http://localhost:4200/ para visualizar a aplicação. :)


## Imagens

![Listing](https://github.com/Emanuelmeira/crud-angular-webapi/blob/master/img/Listing.PNG)

![new](https://github.com/Emanuelmeira/crud-angular-webapi/blob/master/img/new.PNG)

![Details](https://github.com/Emanuelmeira/crud-angular-webapi/blob/master/img/Details.PNG)


```
Duvidas? EmanuelMeira@outlook.com 
```







