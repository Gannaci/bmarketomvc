using bmarketomvc.Contexts;
using bmarketomvc.Models.Entities;

namespace bmarketomvc.Helpers.Repositories
{
    public class UserAddressRepo : Repo<UserAddressEntity>
    {
        public UserAddressRepo(DataContext context) : base(context)
        {
        }
    }
}
