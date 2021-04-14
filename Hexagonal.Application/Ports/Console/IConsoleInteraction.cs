using Hexagonal.Application.Model;
using System.Collections.Generic;

namespace Hexagonal.Application.Ports.Console
{
    public interface IConsoleInteraction
    {
        void ShowBrand(List<BrandDto> brand);
        void ShowEmployees(List<EmployeeDto> employee);
    }
}
