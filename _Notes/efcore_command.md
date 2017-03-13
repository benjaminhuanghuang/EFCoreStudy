## Reference
    
    .NET Command Line Tool
    https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet
    
## Install
    
    The EF Core .NET Command Line Tools are installed by manually editing the *.csproj file.

## List the DbContext to use
    $ dotnet ef dbcontext list
    $ dotnet ef dbcontext info --configuration
    

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
