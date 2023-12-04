# Plano de Testes de Usabilidade

O teste de usabilidade permite avaliar a qualidade da interface com o usuário da aplicação interativa. O Plano de Testes de Software é gerado a partir da especificação do sistema e consiste em casos de testes que deverão ser executados quando a implementação estiver parcial ou totalmente pronta.

Os testes de usabilidade serão realizados com pessoas de fora da equipe supervisionadas por membros da equipe, adotando-se o modelo de descoberta de problemas. Os usuários selecionados serão instruidos a realizar tarfeas relacionadas a funcionalidades do sistema e observados pelos membros da equipe sem ajuda dos mesmos. Os supervisores observarão o uso do sistema pelos usuários e farão anotações sobre possíveis dificuldades que estes venham a ter no uso. Após finalizados os testes, os supervisores perguntarão também sobre possíveis sugestões dos usuários sobre melhorias na usabilidade do sistema. Os resultados de cada teste serão descritos na seção de "Registros de Testes de Usabilidade" presente neste repositório.

As tabelas abaixo demonstram cada caso de teste:

<table> 
<tr><th>Caso de Teste </th>
<th>CT-01 – Realizar cadastro na plataforma</th></tr>
<tr><th>Objetivo do teste</th>
  <th>•	Verificar a usabilidade da funcionalidade de cadastro na plataforma</th></tr>
<tr><th>Ações esperadas</th>
  <th>1 - Usuário visualiza a homepage da aplicação.<br>
 2- Usuário clica na opção de "Fazer login" presente no cabeçalho.<br>
 3– Usuário visualiza a tela de login e clica no botão "Registrar-se".<br>
 4- Usuário preenche todos os campos solicitados para o registro e clica em "Confirmar".<br>
 5- Usuário é redirecionado para a tela de login.</th></tr>
<tr><th>Critérios de Êxito</th>	
  <th>•	Usuário deve ser capaz de realizar o cadastro na plataforma.</th></tr>
  </table>

<table> 
<tr><th>Caso de Teste </th>
<th>CT-02 – Recuperar senha de login</th></tr>
<tr><th>Objetivo do teste</th>
  <th>•	Verificar a usabilidade da funcionalidade recuperação de senha</th></tr>
<tr><th>Ações esperadas</th>
  <th>1 - Usuário visualiza a tela de login da aplicação.<br>
 2– Usuário clica no botão "Esqueci minha Senha".<br>
 3- Usuário preenche todos os campos solicitados para o registro e clica em "Recuperar Senha".<br>
 4- Usuário realiza a recuperação da senha e é levado para tela de login.</th></tr>
<tr><th>Critérios de Êxito</th>	
  <th>•	Usuário deve ser capaz de realizar a recuperação da senha de sua conta préviamente cadastrada.</th></tr>
  </table>

<table> 
<tr><th>Caso de Teste </th>
<th>CT-03 – Realizar Cadastro de Parceiras</th></tr>
<tr><th>Objetivo do teste</th>
  <th>•	Verificar a usabilidade da funcionalidade cadastro de parceiras na plataforma</th></tr>
<tr><th>Ações esperadas</th>
  <th>1 - Usuário visualiza a tela de login da aplicação.<br>
 2- Usuário informa o nome de usuário e senha e clica em "Login".<br>
 3– Usuário visualiza a homepage.<br>
 4- Usuário clica página "Parceiras" no side bar no lado esquerdo da página.<br>
 5- Usuário acessa a página de "Parceiras" clica em cadastrar, preenche os dados corretamente e clica em "Cadastrar".</th></tr>
<tr><th>Critérios de Êxito</th>	
  <th>•	Usuário deve ser capaz de cadastrar uma parceira caso preencha todos os campos apropriadamente.</th></tr>
  </table>

<table> 
<tr><th>Caso de Teste </th>
<th>CT-04 – Realizar o cadastro de Produtos</th></tr>
<tr><th>Objetivo do teste</th>
  <th>•	Verificar a funcionalidade de registro de produtos na plataforma</th></tr>
<tr><th>Ações esperadas</th>
  <th>1 - Usuário visualiza a tela de login da aplicação.<br>
 2- Usuário informa o nome de usuário e senha e clica em "Login".<br>
 3– Usuário visualiza a homepage.<br>
 4- Usuário clica na página "Produtos" no side bar no lado esquerdo da página.<br>
 5- Usuário acessa a página de "Produtos" clicar em cadastrar, preencher os dados corretamente e clicar em "Cadastrar".</th></tr>
<tr><th>Critérios de Êxito</th>	
  <th>•	O usuário deve ser capaz de cadastrar um produto caso preencha todos os campos apropriadamente.</th></tr>
  </table>

<table> 
<tr><th>Caso de Teste </th>
<th>CT-05 – Realizar Consulta de Produtos</th></tr>
<tr><th>Objetivo do teste</th>
  <th>•	Verificar a usabilidade da funcionalidade de consulta de produtos cadastrados afim de ter um controle sobre pagamentos e parceiras relacionados.</th></tr>
<tr><th>Ações esperadas</th>
  <th>1 - Usuário visualiza a tela de login da aplicação.<br>
 2- Usuário informa o nome de usuário e senha e clica em "Login".<br>
 3– Usuário visualiza a homepage.<br>
 4- Usuário clica na página "Produtos" no side bar no lado esquerdo da página.<br>
 5- Usuário ao acessar a página de "Produtos" o usuário encontrará um campo para busca(onde poderá digitar o nome do produto) e o sistema deve mostrar os produtos cadastrados com as informações nome, tamanho, preço, parceira, status do produto. O usuário também terá a opção de deletar o produto ou editar algum dado do mesmo.</th></tr>   
<tr><th>Critérios de Êxito</th>	
  <th>•	O usuário deverá ser capaz de consultar um produto cadastrado utilizando o campo de busca.</th></tr>
  </table>
  
  <table> 
<tr><th>Caso de Teste </th>
<th>CT-06 – Realizar Consulta de Produtos vinculados a uma Parceira</th></tr>
<tr><th>Objetivo do teste</th>
  <th>•	Verificar a usabilidade a funcionalidade de consulta de produtos cadastrados vinculados a uma parceira.</th></tr>
<tr><th>Ações esperadas</th>
  <th>1 - Usuário visualiza a tela de login da aplicação.<br>
 2- Usuário informa o nome de usuário e senha e clica em "Login".<br>
 3– Usuário visualiza a homepage.<br>
 4- Usuário clica na página "Produtos" no side bar no lado esquerdo da página.<br>
 5- Usuário ao acessar a página de "Produtos" o usuário encontrará um campo para busca(onde poderá digitar o nome do produto) e o sistema deve mostrar os produtos cadastrados com as informações nome, tamanho, preço, parceira, status do produto. O usuário também terá a opção de deletar o produto ou editar algum dado do mesmo.</th></tr>
<tr><th>Critérios de Êxito</th>	
  <th>•	O usuário deverá ser capaz de consultar um produto cadastrado utilizando o campo de busca.</th></tr>
  </table>

 <table> 
<tr><th>Caso de Teste </th>
<th>CT-07 – Realizar Consulta de Vendas diárias e valores</th></tr>
<tr><th>Objetivo do teste</th>
  <th>•	Verificar a funcionalidade de consulta valores de vendas diárias e valores por período.</th></tr>
<tr><th>Ações esperadas</th>
  <th>1 - Usuário visualiza a tela de login da aplicação.<br>
 2- Usuário informa o nome de usuário e senha e clica em "Login".<br>
 3– Usuário visualiza a homepage.<br>
 4- Usuário clica na página "Vendas" no side bar no lado esquerdo da página.<br>
 5- Usuário ao acessar a página de "Vendas" o usuário encontrará um campo para selecionar o período inicial e o final de vendas.</th></tr>  
<tr><th>Critérios de Êxito</th>	
  <th>•	O usuário deverá ser capaz de consultar valores de vendas diárias e valores por período.<br>•</th></tr>
  </table>
  
   <table> 
<tr><th>Caso de Teste </th>
<th>CT 08 - Realizar Consulta de Porcentagem de valor repassado a parceira</th></tr>
<tr><th>Objetivo do teste</th>
  <th>•	Verificar a funcionalidade de consulta de Porcentagem de valor repassado a parceira.</th></tr>
<tr><th>Ações esperadas</th>
  <th>1 - Usuário visualiza a tela de login da aplicação.<br>
 2- Usuário informa o nome de usuário e senha e clica em "Login".<br>
 3– Usuário visualiza a homepage.<br>
 4- Usuário clica na página "Vendas" no side bar no lado esquerdo da página.<br>
 5- Ao acessar a página de "Vendas" o usuário encontrará um campo para selecionar o período inicial e o final de vendas. Ao selecionar um período o usuário terá as informações do total de itens vendidos na data e deve clicar no botão "Ver" que levará a tela de resultados de todas as vendas do dia e deverá clicar no botão "Por Parceira" para ver os resultados de vendas vinculadas a cada parceira e assim conseguir verificar a comissão total que deve ser repassada.</th></tr>
<tr><th>Critérios de Êxito</th>	
  <th>•	O usuário deverá ser capaz de consultar de Porcentagem de valor repassado a parceira.</th></tr>
  </table>
