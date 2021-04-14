

using Hexagonal.Application.Model;

namespace Hexagonal.Application
{
    public interface IMainInteraction
    {
        void ShowAllBrandScreens();
        void AddNewBrandAndShowAllBrandSOnScreen(string name);
        void ShowAllBEmployees();
    }
}
