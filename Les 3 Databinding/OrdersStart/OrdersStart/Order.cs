using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersStart
{
    class Order
    {
        
        private int id;
        private string klant;
        private DateTime orderDatum;
        private string product;

        public Order(int id, string klant, DateTime orderDatum,
            string product)
        {
            Id = id;
            Klant = klant;
            Product = product;
            OrderDatum = orderDatum;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Klant
        {
            get
            {
                return klant;
            }

            set
            {
                klant = value;
            }
        }

        public DateTime OrderDatum
        {
            get
            {
                return orderDatum;
            }

            set
            {
                orderDatum = value;
            }
        }

        public string Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }
    }
}
