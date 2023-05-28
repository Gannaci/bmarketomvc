using bmarketomvc.Contexts;
using bmarketomvc.Models.Entities;

namespace bmarketomvc.Helpers.Repositories
{
    public class ContactFormRepo : Repo<ContactFormEntity>
    {
        public ContactFormRepo(DataContext context) : base(context)
        {
        }
    }
}
