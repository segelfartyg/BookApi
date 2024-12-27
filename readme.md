# Book Category Api

## setup process:
1. clone repo, cd into src and run dotnet restore
2. run the following command to run the initial migration to db:

```dotnet ef database update --verbose --project ./BookApi.EntityFrameworkCore/BookApi.EntityFrameworkCore.csproj   --startup-project ./BookApi.WebApi/BookApi.WebApi.csproj```

3. Run the application with dotnet run --project ./BookApi.WebApi/BookApi.WebApi.csproj