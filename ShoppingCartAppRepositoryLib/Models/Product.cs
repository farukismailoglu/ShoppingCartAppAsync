using Trendyol.ShoppingCartApp.Repository.Interface;

namespace Trendyol.ShoppingCartApp.Repository.Models
{
    public partial class Product : Base
    {
        public string Title { get; set; }

        public decimal Price { get; set; }
        public decimal CategoryId { get; set; }

        public virtual Category Category { get; set; }      

    }
}
