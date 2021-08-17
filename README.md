# Teste de Integração Mockado
Pequeno Projeto que realiza testes de integração com o emprego de Mocks.
Projeto Foi feito no Visual Studio Code, em C# puro em Libs criacionais de Mocks.

Para executar os Testes faça:
Na raiz do projeto rode o comando:
  $ dotnet test MoqLibraryTest\MoqLibraryTest.csproj
  
O resultado no terminal deve ser:
  $ Aprovado!  - Com falha:     0, Aprovado:     3, Ignorado:     0, Total:     3, Duração: 37 ms - MoqLibraryTest.dll (net5.0)

Agora va em UsingMoq\MoqLibraryTest e entre no arquivo MoqTest.cs e comente selecionando as linhas 14,15 e 16 e pressione CTRL + K + C
Agora no mesmo araquivo descomente as linhas 19 até 22.
Execute novamente o test:
  $ dotnet test MoqLibraryTest\MoqLibraryTest.csproj
 
O resultado no terminal deve ser:
  $ Com falha! - Com falha:     4, Aprovado:     0, Ignorado:     0, Total:     4, Duração: 55 ms - MoqLibraryTest.dll (net5.0)

Esse Resultado acontece pois nas linhas 19 a 22 o codigo descomentado esta passando dados incorretos assim ele afirmar que nos teste de integração
os dados passados esta incorretos perando o que a classe Mokada espera, logo, o que o contexto externo esta esperando.
