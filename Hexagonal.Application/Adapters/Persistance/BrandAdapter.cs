using Hexagonal.Application.Model;
using Hexagonal.Application.Ports;
using Hexagonal.Persistance;
using Hexagonal.Persistance.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Hexagonal.Application.Adapters
{
    public class BrandAdapter : IBrandInteraction
    {
        private readonly BrandRepository _repo;
        public BrandAdapter(BrandRepository repo)
        {
            _repo = repo;
        }

        public void AddBrand(BrandDto brand)
        {
            _repo.Insert(new Brand() { Name = brand.Name, Id = brand.Id });
        }

        public List<BrandDto> GetAllBrands()
        {
            var list = (from brand in _repo.GetAll().ToList() select new BrandDto() {Name= brand.Name, Id= brand.Id }).ToList();
            return list;
        }
    }
}
