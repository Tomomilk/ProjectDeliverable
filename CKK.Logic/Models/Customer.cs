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
}
