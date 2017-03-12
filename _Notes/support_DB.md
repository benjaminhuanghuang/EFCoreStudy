
# Support Sqlite
## Install Sqlite3
$ brew install sqlite3

## Add reference
<PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version= "1.1.1"/>

## Connect to Sqlite
 public class ApplicationDbContext : DbContext
 {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./confbarrel.db");
        }
 }

## Operate DB
Enter the folder of db file, and Run 
$ sqlite3 confbarrel.db
sqlite> .tables         # display all tables


# Support SQL Server
## Add reference
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version= "1.1.1"/>

## Connection
Add DB context in Startup.cs->ConfigureServices
// Create connection
var connection = @"Server=(localdb)\mssqllocaldb;Database=MyTestDB; Trust_Connection=True;";
services.AddDbContext<AppDBContext>(options=>options.UsSqlServer(connection))
