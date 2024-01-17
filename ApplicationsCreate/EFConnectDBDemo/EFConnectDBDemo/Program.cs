using EFConnectDBDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace EFConnectDBDemo
{
    public class Program
    {
        static void CreateDatabase()
        {
            using (var dbContext = new DataBaseContext())
            {
                string dbname = dbContext.Database.GetDbConnection().Database;

                Console.WriteLine("Creating "+ dbname);

                bool result = dbContext.Database.EnsureCreated();
                string resultString = result ? "Success" : "DB Existed";
                Console.WriteLine($"DB {dbname} : {resultString}");
            }
        }

        static void DeleteDatabase()
        {
            using ( var dbContext = new DataBaseContext())
            {
                string dbname = dbContext.Database.GetDbConnection().Database;

                Console.WriteLine("Removing " + dbname);

                bool result = dbContext.Database.EnsureDeleted();
                string resultString = result ? "Success" : "Failed";
                Console.WriteLine($"DB {dbname} : {resultString}");
            }
        }

        static void InsertProduct(Product p)
        {
            using ( DbContext dbContext = new DataBaseContext() )
            {
                dbContext.Add(p);
                dbContext.SaveChanges();
            }
        }

        static void Main(string[] args)
        {
            Product product1 = new("snack", "back for crack");
            InsertProduct(product1);
        }
    }
}
