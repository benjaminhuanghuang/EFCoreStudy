using Microsoft.EntityFrameworkCore;

namespace EFCoreStudy.WeaponModels
{
    public class AppDBContext : DbContext{
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {}
    }
}