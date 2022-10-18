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

        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<BookOutOfStorage> BooksOutOfStorage { get; set; } = null!;
        public DbSet<LibraryUser> LibraryUsers { get; set; } = null!;
        public DbSet<Person> People { get; set; } = null!;
        public DbSet<Storage> Storages { get; set; } = null!;
    }
}
