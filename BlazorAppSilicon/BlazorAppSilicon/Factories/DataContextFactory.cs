

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using BlazorAppSilicon.Data;


namespace BlazorAppSilicon.Factories;

public class DataContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{

    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlServer("Server=tcp:blazorsilicon.database.windows.net,1433;Initial Catalog=BlazorDatabase;Persist Security Info=False;User ID=Admin_User;Password=!Mario1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}

