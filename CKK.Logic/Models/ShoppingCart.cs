using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class Class1
    {
        private Customer _customer;

        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;

        public void ShoppingCart(Customer cust)
        {
            _customer = cust;
        }

        public int GetCustomerId()
        {
            return _id;
        }

        public ShoppingCartItem GetProductById(int id)
        {
            if( id == 1)
            {
                if( _product1 != null)
                {
                    return _product1;
                }
                else
                {
                    return null;
                }
            }

            else if( id == 2)
            {
                if( _product2 != null)
                {
                    return _product2;
                }
                else
                {
                    return null;
                }
            }

            else if( id == 3)
            {
                if( _product3 != null)
                {
                    return _product3;
                }
                else
                {
                    return null;
                }
            }

            else
            {
                return null;
            }
        }

        


    }
}
