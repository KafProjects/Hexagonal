using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagonal.MainApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            DependencyInjection.CreateAndRegister();
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Druk op een toets om de merken van domo chemicals in te laden.");
            System.Console.ReadLine();


            System.Console.ReadLine();
            System.Console.WriteLine("Druk op een toets om de scherm te sluiten");
            System.Console.ReadLine();
        }
    }
}
