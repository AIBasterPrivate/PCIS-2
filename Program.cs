using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PCIS_2;

internal class Program
{
    private static void Main(string[] args)
    {
        var conf = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json").Build();

        var optionBuilder = new DbContextOptionsBuilder<DbConnection>();
        var libraryDB = new DbConnection(optionBuilder.UseSqlServer(conf.GetConnectionString("Library")).Options);

        var res = libraryDB.BookOutOfStorage.Include(x => x.LibraryUser).Include(x=>x.Book).Include(x=>x.LibraryUser.Person).Include(x=>x.Book.Author).ToList();
        foreach (var item in res)
        {
            Console.WriteLine($"" +
                   $"\t{item.LibraryUser.Person.Firstname}" +
                   $"\t{item.LibraryUser.Person.Middlename}" +
                   $"\t{item.LibraryUser.Person.Lastname}" +
                   $"\t{item.LibraryUser.Person.Adress}" +
                   $"\t{item.LibraryUser.Person.Birthday}" +
                   $"\t{item.LibraryUser.Person.PhoneNumber}" +
                   $"\t{item.Book.BookName}" +
                   $"\t{item.Book.Price}" +
                   $"\t{item.Book.Author.Firstname}" +
                   $"\t{item.Book.Author.Lastname}" +
                   $"\t{item.GiveAwayTime}" +
                   $"\t{item.TakeAwayTime}" +
                   $"\t{item.IsReturned}");
        }
    }


    
}