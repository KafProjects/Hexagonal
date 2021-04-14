
using Hexagonal.Application.Model;
using System.Collections.Generic;

namespace Hexagonal.Application.Ports
{
    public interface IEmployeeInteraction
    {
        List<EmployeeDto> GetEmployees();
    }
}
