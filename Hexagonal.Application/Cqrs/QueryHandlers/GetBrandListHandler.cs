using Hexagonal.Application.Adapters;
using Hexagonal.Application.Model;
using System.Collections.Generic;

namespace Hexagonal.Application.Cqrs.QueryHandlers
{
    public class BrandListRequest : IQuery<List<BrandDto>>
    {
        public BrandListRequest()
        {

        }
    }

    public sealed class BrandListRequestHandler : IQueryHandler<BrandListRequest, List<BrandDto>>
    {
        private BrandAdapter _adapter;
        public BrandListRequestHandler(BrandAdapter adapter)
        {
            _adapter = adapter;
        }
        public List<BrandDto> Handle(BrandListRequest query)
        {
            return _adapter.GetAllBrands();
        }
    }
}
