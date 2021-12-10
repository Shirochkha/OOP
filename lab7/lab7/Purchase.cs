using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Purchase
    {
        public struct Tovar
        {
            public string name;
            public double price;

            public Tovar(string name, double price)
            {
                this.name = name;
                this.price = price;
            }
        }

        public Tovar tovar;
        public double sale;
        public double GetFinalePrice()
        {
            return tovar.price * (1 - sale / 100);
        }

        public Purchase(Tovar tovar)
        {
            this.tovar = tovar;
        }
    }

    public class PurchaseNoSale : Purchase
    {
        public PurchaseNoSale(Tovar tovar) : base(tovar)
        {
            sale = 0;
        }
    }

    public class Purchase10Sale: Purchase
    {
        public Purchase10Sale(Tovar tovar) : base(tovar)
        {
            sale = 10;
        }
    }

    public class Purchase25Sale : Purchase
    {
        public Purchase25Sale(Tovar tovar) : base(tovar)
        {
            sale = 25;
        }
    }

    public class Purchase50Sale : Purchase
    {
        public Purchase50Sale(Tovar tovar) : base(tovar)
        {
            sale = 50;
        }
    }
}
