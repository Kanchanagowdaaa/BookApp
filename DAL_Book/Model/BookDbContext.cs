using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Book.Model
{
    public class BookDbContext:DbContext
    {
        public BookDbContext()
            { }
        public BookDbContext(DbContextOptions<BookDbContext> options)
           : base(options)
        {
        }
        public DbSet<BookDetail>BookDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Set your connection string here
                optionsBuilder.UseSqlServer("Server=KANCHANA\\SQLEXPRESS;Database=kanchana;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
