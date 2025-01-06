# Book Category Api 📚
An API for listing book categories

## Prerequisites:
1. Docker
2. Dotnet 9 SDK/Runtime

## Run it:
1. ```git clone https://github.com/segelfartyg/BookApi.git```
2. ```cd BookApi```
3. ```docker compose up```
4. Go to ```http://localhost:8080/swagger/index.html```

## Local development setup:
1. Run database container: ```docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=YourStrong(!)Password" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest```
2. Run redis container: ```sudo docker run --name bookbapi-redis -p 6379:6379 -d redis```
3. Run the application: ```dotnet run --project ./BookApi.WebApi/BookApi.WebApi.csproj```

