using Hexagonal.Application;
using Hexagonal.Application.Adapters;
using Hexagonal.Application.Adapters.Console;
using Hexagonal.Application.Ports;
using Hexagonal.Application.Ports.Console;
using Hexagonal.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Hexagonal.MainApp
{
    public static class DependencyInjection
    {
        public static IUnityContainer CreateAndRegister()
        {
            var container = new UnityContainer();
            container.RegisterType<ConsoleWrapper>();
            container.RegisterType<IConsoleInteraction, ConsoleAdapter>();
            container.RegisterType<IBrandInteraction, BrandAdapter>();
            container.RegisterType<IEmployeeInteraction, EmployeeAdapter>();
            container.RegisterType<IMainInteraction, MainAdapter>();
            return container;
        }
    }
}
