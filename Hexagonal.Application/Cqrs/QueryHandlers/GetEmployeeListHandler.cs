using Hexagonal.Application.Adapters;
using Hexagonal.Application.Cqrs;
using Hexagonal.Application.Model;
using System.Collections.Generic;

namespace Hexagonal.Application.Cqrs.QueryHandlers
{
    public class EmployeeListRequest : IQuery<List<EmployeeDto>>
    {
        public EmployeeListRequest()
        {
        }
    }

    public sealed class EmployeeListRequestHandler : IQueryHandler<EmployeeListRequest, List<EmployeeDto>>
    {
        private EmployeeAdapter _adapter;
        public EmployeeListRequestHandler(EmployeeAdapter adapter)
        {
            _adapter = adapter;
        }

        public List<EmployeeDto> Handle(QueryHandlers.EmployeeListRequest query)
        {
            return _adapter.GetEmployees();
        }
    }
}

