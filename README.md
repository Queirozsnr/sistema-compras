# Sistema Compras

## Descrição do Projeto

Bem-vindo ao Sistema Compras! Este projeto foi desenvolvido para o teste técnico da Kodigos.

## Configuração do Projeto

### Pré-requisitos

- C#
- Node.js
- Docker

### Configuração do Backend

Para configurar o backend, utilize Docker para construir e executar os containers. Siga os passos abaixo:

1. **Navegue até o diretório do backend:**

    ```bash
    cd backend
    ```

2. **Construa a imagem Docker do backend:**

    ```bash
    docker build . -t backend
    ```

3. **Execute o container Docker do backend:**

    ```bash
    docker run -p 32769:8080 -p 32768:8081 -t -d --name backend backend
    ```
### Configuração do Frontend

Para configurar o ambiente de desenvolvimento do frontend, siga os seguintes passos:

1. **Instale as dependências do projeto:**

    ```bash
    npm install
    ```

2. **Compile e inicie o servidor de desenvolvimento:**

    ```bash
    npm run serve
    ```
