## Create Database
$ dotnet ef migrations add Initial 
This command use the tools added in .csproj file


## Apply migration
$ dotnet ef database update
To Sqlite
Create /bin/Debug/netcoreapp1.1/mytest.db

$ dotnet ef migrations update


## Drop database
$ dotnet ef database drop        # drop database

## Commands
$ dotnet ef -f                   # help
$ dotnet ef database update      # update database
$ dotnet ef migrations add <migration name>
