using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        public Product _product;
        public int _quantity;


        public ShoppingCartItem() { }

        public ShoppingCartItem(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;

        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public Product GetProduct()
        {
            return _product;
        }

        public void SetProduct(Product cartProduct)
        {
            _product = cartProduct;
        }

        public decimal GetTotal()
        {
            return (_quantity * _product._price);
        }
    }
}
