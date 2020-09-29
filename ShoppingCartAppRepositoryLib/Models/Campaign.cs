namespace Trendyol.ShoppingCartApp.Repository.Models
{
    public partial class Campaign : Base
    {
        public string Title { get; set; }
        public int Discount { get; set; }

        public decimal CategoryId { get; set; }
        public virtual Category Category { get; set; }


    }
}
