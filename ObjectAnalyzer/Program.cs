using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileReader = new fileReader();
            var code = fileReader.ReadInTheFile();

            var analyzer = new SourceFileAnalyzer();
            var results = analyzer.GetTheMethodDetails();

            Console.WriteLine(code);

            Console.WriteLine("Press Any Key to Continue")
            Console.ReadKey();
        }
    }
}
