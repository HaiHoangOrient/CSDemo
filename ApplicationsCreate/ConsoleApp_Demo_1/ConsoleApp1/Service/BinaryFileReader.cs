using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.IService;

namespace ConsoleApp1.Model
{
    internal class BinaryFileReader : IFileReader<BinaryFileReader>
    {
        public string ReadFile(BinaryFileReader file)
        {
            //Console.WriteLine($"Read Binary File: {file.ToString}");
            return $"Read Binary File: {file.ToString}";
        }

        public override string ToString()
        {
            return "BinaryFileReader-tostring";
        }
    }
}
