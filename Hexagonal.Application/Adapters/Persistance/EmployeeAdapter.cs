using Hexagonal.Application.Model;
using Hexagonal.Application.Ports;
using Hexagonal.Persistance.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Hexagonal.Application.Adapters
{
    public class EmployeeAdapter : IEmployeeInteraction
    {
        private readonly EmployeeRepository _repo;
        public EmployeeAdapter(EmployeeRepository repo)
        {
            _repo = repo;
        }
        public List<EmployeeDto> GetEmployees()
        {
            return (from employee in _repo.GetAll() select new EmployeeDto() { Name = employee.Name, Id = employee.Id }).ToList();
        }
    }
}
