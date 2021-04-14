
using Hexagonal.Application.Adapters;
using Hexagonal.Application.Cqrs;
using Hexagonal.Application.Model;

namespace cqrs.api.Cqrs.CommandHandlers
{
    public class AddBrandCommand : ICommand
    {
        public string Name { get; set; }
        public AddBrandCommand(string name)
        {
            Name = name;
        }
    }

    public sealed class AddBrandCommandHandler : ICommandHandler<AddBrandCommand>
    {
        private BrandAdapter _adapter;
        public AddBrandCommandHandler(BrandAdapter adapter)
        {
            _adapter = adapter;
        }
        public void Handle(AddBrandCommand command)
        {
            _adapter.AddBrand(new BrandDto() { Name = command.Name });
        }
    }
}
