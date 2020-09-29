using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Trendyol.ShoppingCartApp.Repository.Models
{
    public partial class Category : BaseCategory
    {
        public decimal? ParentCategoryId { get; set; }
        public virtual ICollection<Product> Products { get; set; }       

    }



}
