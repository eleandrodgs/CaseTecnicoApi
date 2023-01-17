
# Case Técnico API  
Projeto de teste de API desenvolvido como parte do processo seletivo no Itáu, que realiza testes na API TheCatApi (https://thecatapi.com/).  

## Tecnologias utilizadas 
C# 6.0

RestSharp 108.0.3

NUnit 3.13.3

## Estrutura do projeto
`Base`: Estrutura responsável por acessar as principais entidades envolvidas no teste de API. 

`Tests:` Diretório que contém a implementação dos testes.

`Helpers:` Classes que dão suporte à execução dos testes, com métodos que configuram a execução e validação das requests.

`Hooks:` Estrutura base para a execução com NUnit.

`Models:` Modelos que devem ser utilizados no envio das requests e na validação das responses. 

`Repositories:`Implementação de métodos que constroem objetos a serem utilizados nos testes.

## Execução do Testes

Primeiramente, realize o clone do projeto. 

### Execução local por prompt de comando
1. Navegue até o diretório raiz do projeto e digite `dotnet build`.
2. Em seguinda, para executar os testes, navegue até o diretório CaseTecnicoApi e digite `dotnet test`.

### Execução local por utilizando o Visual Studio
1. Abra o projeto no VisualStudio 2022.
2. Ative a janela Text Explorer, no menu Tools > Test Explorer.
3. Clique com botão direito em 'Run Tests'.


 






