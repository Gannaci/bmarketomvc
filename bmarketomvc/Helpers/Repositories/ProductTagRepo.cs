using bmarketomvc.Contexts;
using bmarketomvc.Models.Entities;

namespace bmarketomvc.Helpers.Repositories
{
    public class ProductTagRepo : Repo<ProductTagEntity>
    {
        public ProductTagRepo(DataContext context) : base(context)
        {
        }
    }
}
