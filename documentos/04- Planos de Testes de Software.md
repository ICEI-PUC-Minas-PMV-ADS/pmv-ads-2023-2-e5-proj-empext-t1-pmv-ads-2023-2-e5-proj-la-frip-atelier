# Planos de Testes de Software
Os testes funcionais a serem realizados na solução estão descritos a seguir:

|Caso de teste 01     | CT 01 - Cadastro conta de usuário |
|-------|-------------------------
|Requisitos Associados | RF-01: Disponibilizar um sistema de login e autenticação, onde o usuário poderá criar uma conta com dados válidos e realizar login.
|Objetivo do teste| Verificar a funcionalidade de registro de novos usuários no sistema. |
|Passos |	1) Acessar o navegador. 2) Informar a URL do projeto. 3) Clicar na mensagem de "Fazer login" presente no canto direito do cabeçalho. 4) Visualizar tela de login. 5) Clicar no botão "Criar nova conta". 6) Preencher os campos cadastrados e clicar em "Cadastrar" 7) Caso todos os campos tenham sido preenchidos de forma apropriada, o sistema deve retornar uma mensagem de "Usuário cadastrado com sucesso" e redirecionar para a tela de login. |
|Critérios de êxito| - O usuário deverá ser capaz de criar uma nova conta caso preencha todos os campos apropriadamente.<br>- O sistema deverá retornar uma mensagem de erro caso o usuário preencha algum campo de maneira errada (não colocar nome de usuário, inserir um nome de usuário com formatação indevida, inserir uma senha com menos de 4 caracteres ou inserir valores diferentes no campo "senha" e "repetir senha".<br>|

|Caso de teste 02     | CT 02 - Recuperação de senha |
|-------|-------------------------
|Requisitos Associados | RF-01: Disponibilizar um sistema de recuperação de senha, onde o usuário poderá criar uma nova senha com dados válidos e realizar login.
|Objetivo do teste| Verificar a funcionalidade de recuperação de senha. |
|Passos |	1) Acessar o navegador. 2) Informar a URL do projeto. 3) Clicar na mensagem de "Fazer login" presente no canto direito do cabeçalho. 4) Visualizar tela de login. 5) Clicar no botão "Esqueci minha Senha". 6) Preencher os campos cadastrados e clicar em "Recuperar Senha" 7) Caso todos os campos tenham sido preenchidos de forma apropriada, o sistema deve levar usuário a página de "Redefinir Senha" para o usuário cadastrar uma nova senha, caso os dados estejam corretos o sistema retornará a mensagem:"Senha alterada com sucesso!". |
|Critérios de êxito| - O usuário deverá ser capaz de redefinir uma nova senha caso preencha todos os campos apropriadamente.<br>- O sistema deverá retornar uma mensagem de erro caso o usuário preencha algum campo de maneira errada (não colocar nome de usuário, inserir um nome de usuário com formatação indevida, inserir uma senha com menos de 4 caracteres ou inserir valores diferentes no campo "senha" e "repetir senha".<br>|

|Caso de teste 03     | CT 03 - Cadastro de Parceiras |
|-------|-------------------------
|Requisitos Associados | RF-01: Disponibilizar um sistema de cadastro de parceiras afim de ter um controle sobre pagamentos e produtos relacionados.
|Objetivo do teste| Verificar a funcionalidade de registro de parceiras. |
|Passos |	1) Acessar o navegador. 2) Informar a URL do projeto. 3) Clicar na mensagem de "Fazer login" presente no canto direito do cabeçalho. 4) Visualizar tela de login. 5) Informar o nome de usuário e senha e clicar em "login". 6) Acessar o side bar do lado esquerdo da página e clicar em "Parceiras". 7) Ao acessar a página de "Parceiras" clicar em cadastrar, preencher os dados corretamente e clicar em "Cadastrar". |
|Critérios de êxito| - O usuário deverá ser capaz de cadastrar uma parceira caso preencha todos os campos apropriadamente.<br>- O sistema deverá retornar uma mensagem de erro caso o usuário preencha algum campo de maneira errada (não colocar nome completo, telefone, cpf, comissão.<br>|

|Caso de teste 04     | CT 04 - Cadastro de Produtos |
|-------|-------------------------
|Requisitos Associados | RF-01: Disponibilizar um sistema de cadastro de produtos afim de ter um controle sobre pagamentos e parceiras relacionados.
|Objetivo do teste| Verificar a funcionalidade de registro de produtos. |
|Passos |	1) Acessar o navegador. 2) Informar a URL do projeto. 3) Clicar na mensagem de "Fazer login" presente no canto direito do cabeçalho. 4) Visualizar tela de login. 5) Informar o nome de usuário e senha e clicar em "login". 6) Acessar o side bar do lado esquerdo da página e clicar em "Produtos". 7) Ao acessar a página de "Produtos" clicar em cadastrar, preencher os dados corretamente e clicar em "Cadastrar". |
|Critérios de êxito| - O usuário deverá ser capaz de cadastrar um produto caso preencha todos os campos apropriadamente.<br>- O sistema deverá retornar uma mensagem de erro caso o usuário preencha algum campo de maneira errada (não colocar nome completo, tamanho, preço, cpf(Parceira), status do produto.<br>|

|Caso de teste 05     | CT 05 - Consulta de Produtos |
|-------|-------------------------
|Requisitos Associados | RF-01: Disponibilizar um sistema de consulta de produtos cadastrados afim de ter um controle sobre pagamentos e parceiras relacionados.
|Objetivo do teste| Verificar a funcionalidade de consulta de produtos cadastrados. |
|Passos |	1) Acessar o navegador. 2) Informar a URL do projeto. 3) Clicar na mensagem de "Fazer login" presente no canto direito do cabeçalho. 4) Visualizar tela de login. 5) Informar o nome de usuário e senha e clicar em "login". 6) Acessar o side bar do lado esquerdo da página e clicar em "Produtos". 7) Ao acessar a página de "Produtos" o usuário encontrará um campo para busca(onde poderá digitar o nome do produto) e o sistema deve mostrar os produtos cadastrados com as informações nome, tamanho, preço, parceira, status do produto. O usuário também terá a opção de deletar o produto ou editar algum dado do mesmo. |
|Critérios de êxito| - O usuário deverá ser capaz de consultar um produto cadastrado utilizando o campo de busca.<br>- O sistema deverá retornar as informações do produto como: nome completo, tamanho, preço, nome da parceira, status do produto.<br>|

|Caso de teste 06     | CT 06 - Consulta de Produtos vinculados a uma Parceira |
|-------|-------------------------
|Requisitos Associados | RF-01: Disponibilizar um sistema de consulta de produtos vinculados a uma parceira afim de ter um controle sobre pagamentos e parceiras relacionados.
|Objetivo do teste| Verificar a funcionalidade de consulta de produtos cadastrados vinculados a uma parceira. |
|Passos |	1) Acessar o navegador. 2) Informar a URL do projeto. 3) Clicar na mensagem de "Fazer login" presente no canto direito do cabeçalho. 4) Visualizar tela de login. 5) Informar o nome de usuário e senha e clicar em "login". 6) Acessar o side bar do lado esquerdo da página e clicar em "Produtos". 7) Ao acessar a página de "Produtos" o usuário encontrará um campo para busca(onde poderá digitar o nome do produto) e o sistema deve mostrar os produtos cadastrados com as informações nome, tamanho, preço, parceira, status do produto. O usuário também terá a opção de deletar o produto ou editar algum dado do mesmo. |
|Critérios de êxito| - O usuário deverá ser capaz de consultar um produto cadastrado utilizando o campo de busca.<br>- O sistema deverá retornar as informações do produto como: nome completo, tamanho, preço, nome da parceira, status do produto.<br>|

|Caso de teste 07     | CT 07 - Consulta de Vendas diárias e valores |
|-------|-------------------------
|Requisitos Associados | RF-01: Disponibilizar um sistema de consulta de valores de vendas diárias e valores por período.
|Objetivo do teste| Verificar a funcionalidade de consulta valores de vendas diárias e valores por período. |
|Passos |	1) Acessar o navegador. 2) Informar a URL do projeto. 3) Clicar na mensagem de "Fazer login" presente no canto direito do cabeçalho. 4) Visualizar tela de login. 5) Informar o nome de usuário e senha e clicar em "login". 6) Acessar o side bar do lado esquerdo da página e clicar em "Vendas". 7) Ao acessar a página de "Vendas" o usuário encontrará um campo para selecionar o período inicial e o final de vendas. |
|Critérios de êxito| - O usuário deverá ser capaz de consultar valores de vendas diárias e valores por período.<br>- O sistema deverá retornar as informações do produto como: data, total de itens vendidos, saldo total e um botão de ação "Ver".<br>|

|Caso de teste 08     | CT 08 - Consulta de Porcentagem de valor repassado a parceira |
|-------|-------------------------
|Requisitos Associados | RF-01: Disponibilizar um sistema de consulta de Porcentagem de valor repassado a parceira.
|Objetivo do teste| Verificar a funcionalidade de consulta de Porcentagem de valor repassado a parceira. |
|Passos |	1) Acessar o navegador. 2) Informar a URL do projeto. 3) Clicar na mensagem de "Fazer login" presente no canto direito do cabeçalho. 4) Visualizar tela de login. 5) Informar o nome de usuário e senha e clicar em "login". 6) Acessar o side bar do lado esquerdo da página e clicar em "Vendas". 7) Ao acessar a página de "Vendas" o usuário encontrará um campo para selecionar o período inicial e o final de vendas. Ao selecionar um período o usuário terá as informações do total de itens vendidos na data e deve clicar no botão "Ver" que levará a tela de resultados de todas as vendas do dia e deverá clicar no botão "Por Parceira" para ver os resultados de vendas vinculadas a cada parceira e assim conseguir verificar a comissão total que deve ser repassada. |
|Critérios de êxito| - O usuário deverá ser capaz de consultar de Porcentagem de valor repassado a parceira.<br>- O sistema deverá retornar as informações do parceira como: nome, total de itens vendidos, saldo total, comissão total e um botão "Ver" para mais detalhes.<br>|

