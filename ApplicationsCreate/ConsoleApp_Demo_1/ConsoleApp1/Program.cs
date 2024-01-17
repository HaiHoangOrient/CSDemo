using ConsoleApp1.IService;
using ConsoleApp1.Model;
using ConsoleApp1.Service;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {

        var clazzes = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => type.GetInterfaces().Any(interf =>
                interf.IsGenericType && interf.GetGenericTypeDefinition() == typeof(IFileReader<>)))
            .ToList();

        if (clazzes.Count > 0){
            Console.WriteLine("Running...");
        }

        foreach (var clz in clazzes){
            var instance = Activator.CreateInstance(clz);
            BaseFileReader baseFileReader = new BaseFileReader();
            Console.WriteLine(baseFileReader.ReadFile(clz));
        }
    }
}