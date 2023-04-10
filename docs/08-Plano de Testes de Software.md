# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Cenários de testes utilizados na realização dos testes da aplicação, coincidindo com os requisitos funcionais e mostrando os critérios de êxito.

Casos de testes:
 
| **Caso de Teste** 	| **CT-01 – Visualizar tela de login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-03 – A aplicação deve conter login com email e senha.|
| Objetivo do Teste 	| Verificar se a aplicação web exibe todos os elementos requisitados. |
| Passos 	| -                     -                 -     | 
|    1   	|    Acessar o Navegador                        |
|    2    |    Informar o endereço da aplicação web       |
|    3    |    Visualizar a página principal              |
|    4    |    Selecionar a opção de "LOGIN"              |
|    5    |    Visualizar a tela de login                 |
|Critério de Êxito | - Deve ser exibido uma tela de login para a entrada de usuários. |

<br>*

| Caso de Teste 	| CT-02 – Visualizar página de Cadastro	|
|:---:	|:---:	|
|Requisito Associado | RF-02- A aplicação deve permitir o usuário se cadastrar e escolher em qual tipo de usuário se enquadra. Doador ou receptor.|
| Objetivo do Teste 	| Verificar se a aplicação web exibe uma página com campos de preenchimento para o usuário cadastrar os dados. |
| Passos 	| -                     -                 -     | 
|    1   	|    Acessar o Navegador                        |
|    2    |    Informar o endereço da aplicação web       |
|    3    |    Visualizar a página principal              |
|    4    |    Selecionar a opção de "LOGIN"              |
|    5    |    Visualizar a tela de login                 |
|    5    |    Selecionar “Cadastre-se”                   |
|    5    |    Visualizar a página de cadastro            |
|    5    |    Informar os dados de cadastro              |
|    5    |    Selecionar opção “Cadastrar”               |
|Critério de Êxito | - Deve ser exibido após o cadastro a tela de acesso dependendo do tipo de usuário. |

<br>*
 
 | **Caso de Teste** 	| **CT-03 – Visualizar página de Livros** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-04- A aplicação deve permitir a busca por livros de interesse do receptor. |
| Objetivo do Teste 	| Verificar se a aplicação web exibe uma página com os livros disponíveis. |
| Passos 	| -                     -                 -     | 
|    1   	|    Acessar o Navegador                        |
|    2    |    Informar o endereço da aplicação web       |
|    3    |    Visualizar a página principal              |
|    4    |    Selecionar a opção de "LOGIN"              |
|    5    |    Visualizar a tela de login                 |
|    6    |    Realizar o login como Recebedor            |
|    7    |    Visualizar a página de livros              |
|Critério de Êxito | - Deve ser exibido após o login, uma página especifica dos livros cadastrados. |

<br>*

| **Caso de Teste** 	| **CT-04– Visualizar página de Adicionar Livro** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01- A aplicação deve permitir, criar, excluir, editar e gerenciar os livros para doação|
| Objetivo do Teste 	| Verificar se a aplicação web exibe uma página com a opção de adicionar livro. |
| Passos 	| -                     -                 -     | 
|    1   	|    Acessar o Navegador                        |
|    2    |    Informar o endereço da aplicação web       |
|    3    |    Visualizar a página principal              |
|    4    |    Selecionar a opção de "DOE AGORA"          |
|    5    |    Realizar login                             |
|    6    |    Visualizar a página de adicionar livro     |
|    7    |    Selecionar a opção “Adicionar”             |
|    8    |    Informar os dados do livro                 |
|    9    |    Selecionar a opção “Adicionar”             |
|Critério de Êxito | - Deve ser exibido o livro adicionado na lista de livros. |





