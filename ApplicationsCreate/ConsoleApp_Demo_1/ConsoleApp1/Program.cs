using ConsoleApp1.IService;
using ConsoleApp1.Model;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {

        var clazzes = Assembly.GetExecutingAssembly().GetTypes().OfType<IFileReader<object>>().ToList();

        if (clazzes.Count > 0){
            Console.WriteLine("Running...");
        }

        foreach (var clz in clazzes){
            //Console.WriteLine(clz.ToString());
            Console.WriteLine(clz.ReadFile(clz));
        }
    }
}