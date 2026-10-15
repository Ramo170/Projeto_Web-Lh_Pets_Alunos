# Projeto Web LH Pets – Protótipo 1

Back-end em ASP.NET Core (C#) com SQL Server, desenvolvido na atividade de Codificação Back-End (SENAI).

## Rotas

| Rota | Descrição |
|------|-----------|
| `/` | Exibe a versão inicial do projeto: **LH Pets - Protótipo 1** |
| `/index` | Redireciona para a página estática `wwwroot/index.html` (fornecida pelo Front-end) |
| `/listaClientes` | Exibe em HTML a lista de clientes carregada do banco `vendas` (tabela `tblclientes`) |

## Estrutura

- `Program.cs` – configuração da aplicação e mapeamento das rotas
- `Banco.cs` – conexão com o SQL Server; a lista de clientes é um atributo da classe (`private List<Clientes> lista`) exposto por `GetLista()`
- `Clientes.cs` – modelo de dados do cliente
- `vendas.sql` – script que cria o banco `vendas` e a tabela `tblclientes` com dados de exemplo
- `wwwroot/index.html` – página inicial estática

## Como executar

1. Instale o SQL Server Express e o SQL Server Management Studio (SSMS).
2. No SSMS, conecte com o login `sa` (senha `12345`) e execute o script `vendas.sql`.
3. Instale o [.NET SDK 8](https://dotnet.microsoft.com/download/dotnet/8.0).
4. Na pasta do projeto, execute:
   ```bash
   dotnet restore
   dotnet run
   ```
5. Acesse no navegador:
   - http://localhost:5000/
   - http://localhost:5000/index
   - http://localhost:5000/listaClientes

> A string de conexão em `Banco.cs` usa `Server=localhost\SQLEXPRESS`, usuário `sa` e senha `12345`. Ajuste se a sua instalação for diferente.
