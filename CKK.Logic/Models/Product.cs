﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class Product
    {
        public int _id;
        public decimal _price;
        public string _name;

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
            set { _name = Name; }
        }

    }
}
