# Book Category Api

## setup process:
1. clone repo, cd into src and run dotnet restore
2. run the following command to run the initial migration to db:

```dotnet ef database update --verbose --project ./BookApi.EntityFrameworkCore/BookApi.EntityFrameworkCore.csproj   --startup-project ./BookApi.WebApi/BookApi.WebApi.csproj```

3. Run the application with dotnet run --project ./BookApi.WebApi/BookApi.WebApi.csproj

## Docker runs

sudo docker run --name some-mysql -e MYSQL_ROOT_PASSWORD='' -p 3306:3306 -e MYSQL_ALLOW_EMPTY_PASSWORD='yes' -d mysql:latest
sudo docker run --name some-redis -p 6379:6379 -d redis

cd src
sudo docker build -t segelfartyg/bookapi -f Dockerfile .