## API Teste

API RESTful feita para o teste. 

Essa API está utilizando .NET 6.

Utilizei o padrão CQRS com a lib MediatR para implementação da Query de consultar pessoas. 

[Queries](./Nava.Teste.GFaria.Api/Queries/)

 - Queries de consulta de Pessoa;
 - Handlers que processam a chamada.



[Repository](./Nava.Teste.GFaria.Api/Repositories/)

 - Aqui estão as consultas de dados da API.


 
[Nava.Teste.GFaria.Api](./Nava.Teste.GFaria.Api/)

PessoasController "/api/pessoas"
- GetPessoas [Get] : Retorna uma lista de pessoas


## Swagger

URL:
```
/swagger/index.html
```
