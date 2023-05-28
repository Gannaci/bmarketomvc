using bmarketomvc.Contexts;
using bmarketomvc.Models.Entities;

namespace bmarketomvc.Helpers.Repositories
{
    public class AddressRepo : Repo<AddressEntity>
    {
        public AddressRepo(DataContext context) : base(context)
        {
        }
    }
}
