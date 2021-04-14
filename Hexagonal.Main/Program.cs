using Hexagonal.Application;
using System;
using Unity;

namespace Hexagonal.Main
{
    class Program
    {
        public  static void Main(string[] args)
        {
            var unity = DependencyInjection.CreateAndRegister();
                      var mainadapter = unity.Resolve<IMainInteraction>();

            AskAQuestion("Druk op een toets om de merken van domo chemicals in te laden.", () => mainadapter.ShowAllBrandScreens());
            AskAQuestion("Druk op een toets om de medewerkers van domo chemicals in te laden.", () => mainadapter.ShowAllBEmployees());
            mainadapter.AddNewBrandAndShowAllBrandSOnScreen(AskAQuestionAndGetAnswer("Maak een nieuwe brand aan, vul een naam in:... en druk enter")); System.Console.WriteLine("");
            mainadapter.AddNewBrandAndShowAllBrandSOnScreen(AskAQuestionAndGetAnswer("Maak nog eens een nieuwe brand aan, vul een naam in:... en druk enter")); System.Console.WriteLine("");
            AskAQuestion("Druk op een toets om de scherm te sluiten", () => { });
        }

        public static void AskAQuestion(string message, Action action)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(message);           
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.ReadLine();
            action();
            System.Console.WriteLine("");
        }
        public static string AskAQuestionAndGetAnswer(string message)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(message);
            System.Console.WriteLine("");
            System.Console.ForegroundColor = ConsoleColor.White;
            var text= Convert.ToString(System.Console.ReadLine());
            System.Console.WriteLine("");
            return text;
        }
    }
}
