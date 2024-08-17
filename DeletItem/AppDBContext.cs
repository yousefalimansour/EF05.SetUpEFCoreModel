using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF05.SetUpEFCoreModel
{
    internal class AppDBContext : DbContext
    {
        // Represtent collection of all Entities (dbset per table)
        public DbSet<Wallet> Wallets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var constr = configration.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(constr);
        }
    }
}
