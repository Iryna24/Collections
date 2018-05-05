using System;

namespace eShop
{
    public class Jeans : Product
    {
        string name;
        int price;

        public Jeans(string name, int price) : base(name, price)
        {
            this.name = name;
            this.price = price;
        }

    }
}
