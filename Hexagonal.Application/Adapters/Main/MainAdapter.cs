using cqrs.api.Cqrs.CommandHandlers;
using Hexagonal.Application.Cqrs.QueryHandlers;

namespace Hexagonal.Application.Adapters.Console
{
    public class MainAdapter : IMainInteraction
    {
        private readonly BrandListRequestHandler _brandListHander;
        private readonly EmployeeListRequestHandler _employeeListHandler;
        private readonly AddBrandCommandHandler _addBrandHandler;
        private readonly ConsoleAdapter _consoleAdapter;

        public MainAdapter(BrandListRequestHandler brandListHander, EmployeeListRequestHandler employeeListHandler, AddBrandCommandHandler addBrandHandler, ConsoleAdapter consoleAdapter)
        {
             _brandListHander = brandListHander;
            _employeeListHandler = employeeListHandler;
            _addBrandHandler = addBrandHandler;
            _consoleAdapter = consoleAdapter;
        }
        public void AddNewBrandAndShowAllBrandSOnScreen(string name)
        {
            _addBrandHandler.Handle(new AddBrandCommand(name));
            ShowAllBrandScreens();
        }

        public void ShowAllBEmployees()
        {
            _consoleAdapter.ShowEmployees(_employeeListHandler.Handle(new EmployeeListRequest()));
        }

        public void ShowAllBrandScreens()
        {
            _consoleAdapter.ShowBrand(_brandListHander.Handle(new BrandListRequest()));
        }
    }
}
