using System;

namespace eShop
{
    public class Skirt : Product
    {
        string name;
        int price;

        public Skirt(string name, int price) : base(name, price)
        {
            this.name = name;
            this.price = price;
        }

    }
}
