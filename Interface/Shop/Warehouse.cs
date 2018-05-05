using System;
using System.Collections;
using System.Collections.Generic;

namespace eShop
{
    public class Warehouse : IEnumerable
    {
        const int capacity = 50;

        static private List<object> warehouse = new List<object>();
        

        public IEnumerator GetEnumerator()
        {
            return warehouse.GetEnumerator();
        }

        static public void AddProduct(object item)
        {
            warehouse.Add(item);
        }

        static public void RemoveProduct(object item)
        {
            warehouse.Remove(item);
        }
    }
}
