# Book Category Api 📚
An API for listing book categories

## Prerequisites:
1. Docker
2. Dotnet 9 SDK/Runtime

## Run it:
1. ```git clone https://github.com/segelfartyg/BookApi.git```
2. ```cd BookApi```
3. ```cd src```
4. ```sudo docker build -t segelfartyg/bookapi -f Dockerfile . ```
3. ```cd .. ```
5.  ```docker compose up```

## Local development setup:
1. Run database container: ```sudo docker run --name bookapi-mysql -e MYSQL_ROOT_PASSWORD='' -p 3306:3306 -e MYSQL_ALLOW_EMPTY_PASSWORD='yes' -d mysql:latest```
2. Run redis container: ```sudo docker run --name bookbapi-redis -p 6379:6379 -d redis```
3. Run the application: ```dotnet run --project ./BookApi.WebApi/BookApi.WebApi.csproj```