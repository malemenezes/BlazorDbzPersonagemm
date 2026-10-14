# BlazorDbzPersonagem

Aplicação Blazor (.NET 10) que consome a [Dragon Ball API](https://dragonball-api.com).

O usuário informa o **id** de um personagem e a aplicação busca os dados no endpoint
`https://dragonball-api.com/api/characters/{id}`, exibindo na tela:

- **Nome**
- **Planeta de origem**
- **Transformações**

## Como executar

```bash
dotnet run
```

Depois é só abrir o endereço que aparece no terminal (por padrão `http://localhost:5164`)
e digitar um id, como `1` (Goku) ou `2` (Vegeta).

## Estrutura

- `Models/Personagem.cs`: classes que mapeiam o JSON da API (`Personagem`, `Planeta`, `Transformacao`)
- `Components/Pages/Home.razor`: página com o campo de id, a chamada à API e a exibição dos dados
- `Program.cs`: registro do `HttpClient` com o endereço base da API
