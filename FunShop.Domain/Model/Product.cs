using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Model
{
    public abstract class Product: PurchaseOrderItem
    {
        public string Title { get; private set; }
        
        public Product(string title, decimal cost):base()
        {
            this.Title = title;
            this.Cost = cost;
       }
    }
}
