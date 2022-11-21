using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS_2
{
    internal class DbConnection :DbContext
    {
        public DbConnection(DbContextOptions<DbConnection> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Author> Author { get; set; } = null!;
        public DbSet<Book> Book { get; set; } = null!;
        public DbSet<BookOutOfStorage> BookOutOfStorage { get; set; } = null!;
        public DbSet<LibraryUser> LibraryUser { get; set; } = null!;
        public DbSet<Person> Person { get; set; } = null!;
        public DbSet<Storage> Storage { get; set; } = null!;
    }
}
