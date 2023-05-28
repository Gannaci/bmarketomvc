using bmarketomvc.Models.ViewModels;

namespace bmarketomvc.Helpers.Services
{
    public class ProductitemService
    {
        private ProductitemViewModel productitem = new ProductitemViewModel()
        {
            ImageUrl = "images/270x295.svg",
            Title = "Apple Watch",
            Price = "$30.00"
        };

        public ProductitemViewModel GetProductitem()
        {
            return productitem;
        }
    }
}
