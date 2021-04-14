using Hexagonal.Application.Model;
using Hexagonal.Application.Ports.Console;
using Hexagonal.Console;
using System.Collections.Generic;

namespace Hexagonal.Application.Adapters.Console
{
    public class ConsoleAdapter : IConsoleInteraction
    {
        public readonly ConsoleWrapper _console;
        public ConsoleAdapter(ConsoleWrapper wrapper)
        {
            _console = wrapper;
        }    
        public void ShowEmployees(List<EmployeeDto> employees)
        {
            foreach (var item in employees)
            {
                _console.WriteLine($"Employee {item.Name} has id {item.Id} ");
            }
        }

        public void ShowBrand(List<BrandDto> brands)
        {
            foreach (var item in brands)
            {
                _console.WriteLine($"Brand {item.Name} has id {item.Id} ");
            }
        }
    }
}
