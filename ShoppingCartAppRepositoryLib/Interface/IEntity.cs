using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol.ShoppingCartApp.Repository.Interface
{
    public interface IEntity<ID>
    {
        public ID Id { get; set; }
    }
}
