## Create Database
$ dotnet ef migrations add Initial 
This command use the tools added in .csproj file


## Apply migration
$ dotnet ef database update
To Sqlite
Create /bin/Debug/netcoreapp1.1/mytest.db