using bmarketomvc.Contexts;
using bmarketomvc.Models.Entities;

namespace bmarketomvc.Helpers.Repositories
{
    public class TagRepo : Repo<TagEntity>
    {
        public TagRepo(DataContext context) : base(context)
        {
        }
    }
}
