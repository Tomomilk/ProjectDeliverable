using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{

    class Customer
    {
        private int _id;
        private string _name;
        private string _address;

        public Customer(int id, string name, string address)
        {
            _id = id;
            _name = name;
            _address = address;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public string Name
        {
            get { return _name; }
            set { _name = Name;  }
        }

        public string Address
        {
            get { return _address; }
            set { _address = Address; }
        }


    }

    class Product
    {
        private int _id;
        private decimal _price;
        private string _name;

        public Product(string name, decimal price, int id)
        {
            _id = id;
            _price = price;
            _name = name;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public void SetPrice(decimal price)
        {
            _price = price;
        }

        public string Name
        {
            get { return _name; }
            set { _name = Name;  }
        }

    }
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

    class ShoppingCartItem
    {
        private string _product;
        private int _quantity;

        public ShoppingCartItem(string product, int quantity)
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
