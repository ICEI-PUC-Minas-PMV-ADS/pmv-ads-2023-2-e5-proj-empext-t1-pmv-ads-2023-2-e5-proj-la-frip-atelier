# Instruções de utilização

Para realizar a instalação do site em sua própria máquina, siga os passos abaixo. Essas instruções são independentes da plataforma de hospedagem e banco de dados, permitindo que você execute a aplicação localmente para desenvolvimento ou teste.

## Instalação do Site

### Pré-requisitos

1. **Ambiente de Desenvolvimento:**
   - Certifique-se de ter um ambiente de desenvolvimento configurado com o .NET para a aplicação.

2. **Git:**
   - Instale o Git para clonar o repositório da aplicação.

3. **Docker:**
   - Tenha o Docker instalado para a criação e execução do contêiner da aplicação.

4. **MySQL:**
   - Instale o MySQL para ser utilizado como o banco de dados da aplicação. Certifique-se de configurar um usuário, senha e banco de dados conforme necessário.

### Passos para Instalação

1. **Clone o Repositório:**
   - Abra o terminal e execute o seguinte comando para clonar o repositório:
     ```bash
     git clone https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e5-proj-empext-t1-pmv-ads-2023-2-e5-proj-la-frip-atelier.git
     ```

2. **Acesse o Diretório da Aplicação:**
   - Navegue até o diretório recém-clonado:
     ```bash
     cd pmv-ads-2023-2-e5-proj-empext-t1-pmv-ads-2023-2-e5-proj-la-frip-atelier/codigo-fonte/
     ```

3. **Configuração do MySQL:**
   - Configure a conexão com o MySQL na aplicação, ajustando as configurações no arquivo de configuração ou por meio de variáveis de ambiente.

4. **Build da Aplicação:**
   - Execute o seguinte comando para construir a aplicação:
     ```bash
     dotnet build
     ```

5. **Criação do Contêiner:**
   - Utilize o Docker para criar um contêiner a partir da aplicação:
     ```bash
     docker build -t nome-do-contêiner .
     ```

6. **Execução do Contêiner:**
   - Inicie o contêiner:
     ```bash
     docker run -p 8080:80 nome-do-contêiner
     ```

7. **Acesse o Site Localmente:**
   - Abra um navegador e acesse [http://localhost:8080](http://localhost:8080) para visualizar o site localmente.


Ao seguir essas instruções, você terá a aplicação utilizando o MySQL como banco de dados e rodando em sua máquina local. Lembre-se de ajustar as configurações conforme necessário para atender aos requisitos específicos da aplicação que está instalando.
