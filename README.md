
# RubCubeBack — Guia de execução e exemplos de uso

Este documento fornece instruções formais e objetivas para iniciar, testar e depurar a API RubCubeBack em ambiente de desenvolvimento (IDE) e em contêineres (Docker). Inclui exemplos de requests e responses para as rotas expostas.

Requisitos

- .NET 10 SDK
- Visual Studio 2026 / VS Code / outra IDE que suporte .NET 10
- Docker Desktop (quando optar por execução em contêiner)
- (Opcional) Postman ou curl

1) Execução local (IDE)

Passos recomendados

1. Abra `RubCubeBack.sln` na sua IDE.
2. Atualize `RubCubeBack/appsettings.Development.json` com as connection strings apropriadas:
   - `ConnectionStrings:DefaultConnection` (Postgres).
   - `ConnectionStrings:Redis` (Redis).
3. Se não houver Postgres/Redis locais, utilize o `docker compose` (seção 3).
4. Defina `RubCubeBack` como projeto de inicialização e execute (F5). A aplicação chama `RunMigrations()` na inicialização e aplicará migrações se o banco estiver acessível.

Aplicar migrações manualmente (opcional):

```powershell
dotnet tool install --global dotnet-ef
dotnet ef database update --project RubCubeBack.Infra --startup-project RubCubeBack
```

2) Execução com Docker

2.1 Build da imagem

```powershell
docker build -t rubcubeback:latest .
```

2.2 Executar a imagem (exemplo)

```powershell
docker run -e ASPNETCORE_ENVIRONMENT=Development \
  -e ConnectionStrings__DefaultConnection="Host=db;Port=5432;Database=rubcube;User Id=postgres;Password=postgres;" \
  -p 8080:80 rubcubeback:latest
```

2.3 Docker Compose (recomendado)

O repositório inclui um `docker-compose.yml` que provisiona os serviços necessários (API, Postgres e Redis) com healthchecks. Para subir a stack:

```powershell
docker compose up -d --build
```

- A API ficará disponível em `http://localhost:8080`.
- Para encerrar e remover recursos:

```powershell
docker compose down -v
```

3) Endpoints — exemplos de requests e responses

Observação: os exemplos usam dados genéricos. Substitua `<token>` pelo JWT obtido em `/api/auth`.

Base URL (ex.: docker-compose): `http://localhost:8080`

3.1 POST /api/auth — Autenticação

Request (JSON):

```json
{ "email": "user@example.com", "password": "Password123!" }
```

Response (200):

```json
{ "token": "<JWT>", "expiration": "2026-02-13T12:34:56Z" }
```

3.2 POST /api/user — Criar usuário

Request (JSON):

```json
{
  "name": "First",
  "lastName": "Last",
  "email": "user@example.com",
  "password": "Password123!"
}
```

Response (200):

```json
"<JWT>"
```

3.3 GET /api/user — Listar usuários

Request exemplo:

```
GET /api/user?page=1&pageSize=10
```

Response (200):

```json
{
  "page": 1,
  "pageSize": 10,
  "items": [
    { "name": "First", "lastName": "Last", "email": "user@example.com" },
    { "name": "Another", "lastName": "User", "email": "another.user@example.com" }
  ]
}
```

3.4 PUT /api/user — Atualizar usuário (autenticado)

Headers:

```
Authorization: Bearer <token>
```

Request (JSON):

```json
{ "name": "First Updated", "lastName": "Last", "password": "NewPassword123!" }
```

Response (200):

```json
{ "name": "First Updated", "lastName": "Last", "email": "user@example.com" }
```

3.5 DELETE /api/user — Remover usuário (autenticado)

Headers:

```
Authorization: Bearer <token>
```

Response (204): sem conteúdo

3.6 GET /api/coin — Preços filtrados (autenticado)

Request exemplo:

```
GET /api/coin?symbols=USD,EUR&minValue=0.5&page=1&pageSize=10
Authorization: Bearer <token>
```

Response (200):

```json
{
  "page": 1,
  "pageSize": 10,
  "items": {
    "USD": 1.0,
    "EUR": 0.93
  }
}
```

3.7 GET /api/coin/availablesymbols — Símbolos disponíveis (autenticado)

Response (200):

```json
["USD","EUR","GBP","JPY"]
```

3.8 GET /api/log/GetLogs — Recuperar logs (autenticado)

Descrição: retorna logs de requisições com paginação e filtros por usuário, intervalo de data e endpoint.

Headers:

```
Authorization: Bearer <token>
```

Parâmetros de consulta (query string):
- `page` (opcional) — número da página (padrão 1)
- `pageSize` (opcional) — tamanho da página (padrão 10)
- `userId` (opcional) — id do usuário (GUID)
- `startAt` / `endAt` (opcional) — filtro por intervalo de criação (ISO 8601)
- `endpoint` (opcional) — filtro por fragmento de caminho

Request exemplo:

```
GET /api/log/GetLogs?page=1&pageSize=5&endpoint=/api/user&startAt=2026-02-01T00:00:00Z&endAt=2026-02-14T23:59:59Z
Authorization: Bearer <token>
```

Response (200) — exemplo:

```json
{
  "page": 1,
  "pageSize": 5,
  "items": [
    {
      "id": "b3f1c2d4-1a2b-4c3d-9e0f-1234567890ab",
      "path": "/api/user",
      "request": "{\"name\":\"First\"}",
      "userId": "6f1e2d3c-4b5a-6789-0abc-def123456789",
      "statusCode": 200,
      "created": "2026-02-13T10:15:30Z"
    },
    {
      "id": "c4d5e6f7-2345-6789-abcd-0987654321fe",
      "path": "/api/auth",
      "request": "{\"email\":\"user@example.com\"}",
      "userId": null,
      "statusCode": 401,
      "created": "2026-02-13T11:00:00Z"
    }
  ]
}
```

Exemplo curl:

```bash
curl "http://localhost:8080/api/log/GetLogs?page=1&pageSize=5&endpoint=/api/user" \
  -H "Authorization: Bearer <token>"
```


4) Exemplos rápidos com curl

Criar usuário:

```bash
curl -X POST http://localhost:8080/api/user \
  -H "Content-Type: application/json" \
  -d '{"name":"First","lastName":"Last","email":"user@example.com","password":"Password123!"}'
```

Autenticar:

```bash
curl -X POST http://localhost:8080/api/auth \
  -H "Content-Type: application/json" \
  -d '{"email":"user@example.com","password":"Password123!"}'
```

Consultar preços (com token):

```bash
curl "http://localhost:8080/api/coin?page=1&pageSize=10" \
  -H "Authorization: Bearer <token>"
```

5) Solução de problemas

- Se a aplicação não localizar o Postgres/Redis em execução local, atualize `appsettings.Development.json` para apontar para `localhost` ou utilize `docker compose up` para provisionar os serviços.
- Para visualizar logs em Docker:

```powershell
docker compose logs -f rubcubeback
```

- Confirme que as migrações existem no projeto de infraestrutura; a aplicação invoca `Database.Migrate()` na inicialização.

6) Limpeza

```powershell
docker compose down -v
docker rmi rubcubeback:latest
```

7) Exemplos visuais
## **Swagger**

![Swagger](https://i.imgur.com/cWAfPcX.png)

## **User**

- **`api/User/GetUsers`**

![Unauthorized GetUsers](https://i.imgur.com/LkPAuY4.png)
![Ok GetUsers](https://i.imgur.com/jdM9f9q.png)

- **`api/User/CreateUser`**

![BadRequest CreateUser](https://i.imgur.com/6ykeLe4.png)
![Ok CreateUser](https://i.imgur.com/cft2oPD.png)

- **`api/User/UpdateUser`**

![Unauthorized UpdateUser](https://i.imgur.com/g3Ha4wN.png)
![BadRequest UpdateUser](https://i.imgur.com/rf4MZm5.png)
![Ok UpdateUser](https://i.imgur.com/UKK82IT.png)

- **`api/User/DeleteUser`**

![Unauthorized DeleteUser](https://i.imgur.com/UIMlJC4.png)
![NoContent DeleteUser](https://i.imgur.com/XLtjcCA.png)

## **Auth**
- **`api/Auth/login`**

![Unauthorized Login](https://i.imgur.com/4SmEu3n.png)
![BadRequest Login](https://i.imgur.com/rf4MZm5.png)
![Ok Login](https://i.imgur.com/6KVb6C2.png)

## **Logs**
- **`api/Logs/GetLogs`**

![Unauthorized Log](https://i.imgur.com/2nDopIU.png)
![Ok Log](https://i.imgur.com/m6zv5PZ.png)

## **Coin**
- **`api/Coin/AvailableSymbols`**


![Unauthorized AvailableSymbols](https://i.imgur.com/Gahs8pz.png)
![Ok AvailableSymbols](https://i.imgur.com/m6zv5PZ.png)
- **`api/Coin/GetCoinsInfo`**

![Unauthorized GetCoinsInfo](https://i.imgur.com/vkr6UVX.png)
![Ok GetCoinsInfo](https://i.imgur.com/Jf9KYSx.png)


