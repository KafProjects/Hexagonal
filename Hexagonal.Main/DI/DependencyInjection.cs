using cqrs.api.Cqrs.CommandHandlers;
using Hexagonal.Application;
using Hexagonal.Application.Adapters;
using Hexagonal.Application.Adapters.Console;
using Hexagonal.Application.Cqrs;
using Hexagonal.Application.Cqrs.QueryHandlers;
using Hexagonal.Application.Model;
using Hexagonal.Application.Ports;
using Hexagonal.Application.Ports.Console;
using Hexagonal.Console;
using System.Collections.Generic;
using Unity;

namespace Hexagonal.Main
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
            container.RegisterType<IQueryHandler<BrandListRequest, List<BrandDto>>, BrandListRequestHandler>();
            container.RegisterType<IQueryHandler<EmployeeListRequest, List<EmployeeDto>>, EmployeeListRequestHandler>();
            container.RegisterType<ICommandHandler<AddBrandCommand>, AddBrandCommandHandler>();
            container.RegisterType<IMainInteraction, MainAdapter>();
            return container;
        }

    }
}
