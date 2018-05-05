using System;

namespace eShop
{
    public class TShirt : Product
    {
        string name;
        int price;

        public TShirt(string name, int price) : base(name, price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
