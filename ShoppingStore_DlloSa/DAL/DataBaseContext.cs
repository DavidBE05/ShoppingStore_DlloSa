using Microsoft.EntityFrameworkCore;
using ShoppingStore_DlloSa.DAL.Entities;

namespace ShoppingStore_DlloSa.DAL
{
    public class DataBaseContext : DbContext
    {
        // Este construtor, creo la referencia de DbContextOptions que me sirve para configurar las opciones de la BD 
        public DataBaseContext(DbContextOptions<DataBaseContext>options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c=>c.Name).IsUnique(); //Con esta linea controlo la duplicidad de mis paies
        }

        //DbSet me sirve para convetri mi calse en una tabla de BD
        public DbSet<Country> Countries { get; set; }   


    }
}
