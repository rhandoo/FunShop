using FunShop.Model;
using FunShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Processor
{
    public class ProductOrderItemHandler : PurchaseOrderItemHandler<Product>
    {
        private IShippingSlipService shippingSlipService;

        public ProductOrderItemHandler(Product purchaseOrderItem) : this(purchaseOrderItem, new ShippingSlipService())
        {
        }

        public ProductOrderItemHandler(Product purchaseOrderItem, IShippingSlipService shippingSlipService) : base(purchaseOrderItem)
        {
            this.shippingSlipService = shippingSlipService;
        }

        protected override void ProcessItem(Product purchaseOrderItem)
        {
            this.shippingSlipService.GenerateShippingSlip(purchaseOrderItem);
        }
    }
}