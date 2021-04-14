using Hexagonal.Application.Model;
using System.Collections.Generic;

namespace Hexagonal.Application.Ports
{
    public interface IBrandInteraction
    {
        List<BrandDto> GetAllBrands();
        void AddBrand(BrandDto brand);
    }
}
