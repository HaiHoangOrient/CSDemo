using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.IService;

namespace ConsoleApp1.Model
{
    internal class SQLReader : IFileReader<SQLReader>
    {
        public string ReadFile(SQLReader file)
        {
            //Console.WriteLine($"Read SQL file: {file.ToString}");
            return $"Read SQL file: {file.ToString}";
        }

        public override string ToString()
        {
            return "SQLFileRead-tostring";
        }
    }
}
