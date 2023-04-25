# Especificações do Projeto

Na seção a seguir pode-se observar o diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas na tabela que se segue.

| Persona     | Roberto Xerxes Jr. | Roseane Azevedo Coutinho | Ana Júlia                    |
|-------------|--------------------|--------------------------|------------------------------|
| Idade       | 50                 | 30                       | 11                           |
| Ocupação    | Juiz de Direito    | Faxineira                | Estudante Ensino Fundamental |
| Aplicativos | Facebook, Instagram, Twitter | LinkedIn, Uber, Instagram | Facebook, TikTok, Twitter
| Motivações  | Conhecer o mundo, escrever um livro, mudar pro exterior. Ajudar as pessoas. Conscientizar pessoas sobre a importância de ler livros e ter acesso a conhecimento e cultura.            | Deseja dar uma boa formação acadêmica aos seus filhos; Deseja ter uma melhor qualidade de vida; Quer ainda cursar ensino superior. |                                     Quer aproveitar o ensino escolar; Deseja ser professor |
| Insatisfações | Tem livros guardados em casa, porém, não sente confortável em passa-los pra frente por não ter meios confiáveis de doá-los. Tem a opinião de que os livros são muito caros.| Pouco acesso à literatura; Não possui muitas opções de lazer | Encontra-se em um grande limite financeiro; Não tem acesso a uma diversidade literária |
| Hobbies | Viajar, conhecer museus. Frequentar eventos sociais, festas, eventos beneficentes. | Gosta de ler; Cuidar dos filhos; Gosta de ficar por dentro das notícias e debater sobre temas relevantes. | Gosta de desenhar, pintar; Reunir os amigos e conversar, jogar bola, ler, ir ao cinema, assistir séries e filmes. |

## Histórias de Usuários

| Persona/Usuário          | O que | Por quê |
|--------------------------|-------|---------|
| Roberto Xerxes Jr.       | possui uma série de livros jurídicos disponíveis para coleta e doação dos usuários interessados, ocorre que há enorme dificuldade de fazer chegar esta informação principalmente aos estudantes de direito. | Avalia que necessita de iniciativa tecnológica transformadora para todos os segmentos que facilite e propicie esta intermediação e, principalmente o jurídico, pois a leitura é algo indispensável na nossa esfera. |
| Roseane Azevedo Coutinho | fala da importância de doar livros. Acha que livros são importantes demais para ficarem parados. | Busca uma forma confortável e segura de adquirir livros de forma gratuita. | 
| Ana Júlia                | Sente que os livros que leu foram importantes para o desenvolvimento de sua personalidade. | Quer encontrar livros gratuitos, uma vez que livros para comprar são caros. |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade que os mesmos devem ser entregues.

|ID      | Descrição do Requisito  | Prioridade|
|--------|-------------------------|-----------|
|RF01   | A aplicação deve permitir, criar, excluir, editar e gerenciar os livros para doação |ALTA|
|RF02   | A aplicação deve permitir o usuário se cadastrar e escolher em qual tipo de usuário se enquadra. Doador ou receptor |ALTA|
|RF03   | A aplicação deve permitir que o usuário se autentique com email e senha |ALTA|
|RF04   | A aplicação deve permitir a busca por livros de interesse do receptor |ALTA|
|RF05   | A aplicação deve permitir o registro de interesse a determinado livro por parte do receptor |ALTA|
|RF06   | A aplicação deverá fornecer uma forma de comunicação entre usuário doador e usuário receptor, ainda que por meio do uso de aplicações terceiras. |ALTA|



### Requisitos não Funcionais
A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|-----------|
|RNF01| O sistema deve ser responsivo para que possa ser executado em um dispositivos móvel | MÉDIA | 
|RNF02| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 
|RNF03| Necessário conexão com a internet para poder usufruir do sistema.| MÉDIA | 
|RNF05| A aplicação web deverá ter disponibilidade em todos os horários. |MÉDIA|
|RNF06| Os dados inseridos pelos usuários na tela de login serão cadastrados no banco de dados.|ALTA|
|RNF07| A aplicação deve ser de fácil usabilidade e apresentar telas bem elaboradas e de fácil utilização |ALTA|

## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações nítidas para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID   | Restrição                                             |
|-----|-------------------------------------------------------|
|RE01| O projeto deverá ser entregue até o final do semestre |
|RE02| O aplicativo deve se restringir as tecnologias básicas de desenvolvimento Web como Back-End|
|RE03| A equipe não pode subcontratar o desenvolvimento do trabalho|

## Diagrama de Casos de Uso

A seguir, o diagrama de casos de uso contendo de forma gráfica a ligação entre os requisitos funcionais descritos no projeto e seus respectivos atores.

![Diagrama de caso de uso(1)](https://user-images.githubusercontent.com/44789183/230789087-505877f2-47d9-465a-ac1e-da8d44e0cf23.jpeg)


