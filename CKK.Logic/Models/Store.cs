using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private Product _product1 = null;
        private Product _product2 = null;
        private Product _product3 = null;
        

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

        public void AddStoreItem(Product prod)
        {
            if( _product1 == null)
            {
                _product1 = prod;
            } 

            else if ( _product2 == null )
            {
                _product2 = prod;
            }

            else if ( _product3 == null )
            {
                _product3 = prod;
            }

        }

        public void RemoveStoreItem(int productNum)
        {
            
        }

        public Product GetStoreItem(int productNum)
        {
            if(productNum == 1)
            {
                if (_product1 != null)
                {
                    return _product1;
                }

                else
                {
                    return null;
                }
            }
            
            else if (productNum == 2)
            {
                if (_product2 != null)
                {
                    return _product2;
                }

                else
                {
                    return null;
                }
            }

            else if (productNum == 3)
            {
                if(_product3 != null)
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

        public Product FindStoreItemById(int id)
        {
            if (id == 1)
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

            else if (id == 2)
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

            else if (id == 3)
            {
                if(_product3 != null)
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
