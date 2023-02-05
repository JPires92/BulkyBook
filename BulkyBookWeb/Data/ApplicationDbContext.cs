using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        /// <summary>
        /// /Create Category table with the name Categories
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /* Depois de criar a class, configurar o 'Program.cs', para criarmos a DB automaticamente, temos de:
            Abrir consola e :
                add-migration AddCategoryToDatabase
                update-database
         */
    }
}
