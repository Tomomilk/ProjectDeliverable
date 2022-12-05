using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{

    public class Customer
    {
        public int _id;
        public string _name;
        public string _address;


        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetAddress()
        {
            return _address; 
        }

        public void SetAddress(string address)
        {
            _address = address;
        }


    }
}
