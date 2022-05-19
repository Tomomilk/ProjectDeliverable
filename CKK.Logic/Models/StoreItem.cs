using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class StoreItem
    {
        private string _product;
        private int _quantity;

        public StoreItem(string product, int quantity)
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

        public string Product
        {
            get { return _product; }
            set { _product = Product; }
        }

    }
}
