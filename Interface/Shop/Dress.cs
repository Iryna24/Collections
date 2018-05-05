using System;

namespace eShop
{
    public class Dress : Product
    {
        string name;
        int price;

        public Dress(string name, int price) : base(name, price)
        {
            this.name = name;
            this.price = price;
        }

    }
}
