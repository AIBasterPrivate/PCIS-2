using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PCIS_2;

internal class Program
{
    private static void Main(string[] args)
    {
        var conf = new ConfigurationBuilder()
            .AddJsonFile("C:\\Users\\KedrAdmin\\source\\repos\\PCIS-2\\appsettings.json").Build();

        var optionBuilder = new DbContextOptionsBuilder<DbConnection>();
        var libraryDB = new DbConnection(optionBuilder.UseSqlServer(conf.GetConnectionString("Library")).Options);
        


    }
}