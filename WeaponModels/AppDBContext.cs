using Microsoft.EntityFrameworkCore;

namespace EFCoreStudy.WeaponModels
{
    public class AppDBContext : DbContext{
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {}
    }


    public class WeaponModels{
        [Key]
        [D]
        public int Id{get;set;}
        public string Name { get; set; }

        public string  Description { get; set; }

        public int WeaponTypeId { get; set; }

        public WeaponType Type { get; set; }
    }

    public Type









}