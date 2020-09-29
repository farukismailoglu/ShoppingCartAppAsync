using Trendyol.ShoppingCartApp.Repository.Interface;

namespace Trendyol.ShoppingCartApp.Repository.Models
{
    public class Base : IEntity<decimal>
    {
        public decimal Id { get; set; }

    }

    public class BaseCategory : Base
    {
        public string Title { get; set; }

    }
}
