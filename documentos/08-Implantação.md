# Implantação do Software

O sistema do brechó La Frip Atelier foi implantado com sucesso na plataforma **Fly.io**, utilizando containers Docker para simplificar o processo de implantação. A escolha pelo **Fly.io** proporcionou não apenas escalabilidade, mas também desempenho de maneira econômica. Já a base de dados, hospedada no **PlanetScale** com MySQL, garante um ambiente seguro e escalável.

## Processo de Implantação

Para a hospedagem do banco de dados:

1. Criamos uma conta na plataforma **PlanetScale**.
2. Foi configurada uma base de dados, armazenando a string de acesso gerada.
3. Criamos uma branch "develop" para realizar as modificações de esquema.
4. Utilizamos os `migrations` gerados pelo .NET na aplicação para criar as tabelas necessárias.
5. Foi realizado o deploy das tabelas criadas da branch "develop" para a branch principal, "main".

Para hospedar o site:

1. Foi criado um `Dockerfile` para a aplicação, permitindo a criação de um container.
2. Editamos a string de conexão do banco de dados no arquivo `appsettings.json` da aplicação.
3. Instalamos o `flyctl`, a ferramenta CLI do **Fly.io**, para poder implementar a aplicação.
4. Criamos e configuramos a máquina virtual com o auxílio da ferramenta CLI do **Fly.io**.
5. Foi realizado o deploy da aplicação, utilizando a ferramenta que identificou automaticamente o `Dockerfile` existente.

O link para acesso a plataforma é: https://lafripatelier.fly.dev
