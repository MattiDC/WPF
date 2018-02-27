using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersStart
{
    class Orders : List<Order>
    {
        public Orders()
        {
            Add(new Order(1001, "Bart Degroot", new DateTime(2017, 1, 23), "Blue Sweater"));
            Add(new Order(1002, "Ben Volders", new DateTime(2017, 1, 24), "Brown Pant W"));
            Add(new Order(1003, "Ann Braet", new DateTime(2017, 1, 24), "Orange T-shirt"));
            Add(new Order(1004, "Carla Verwaest", new DateTime(2017, 1, 25), "Green skirt"));
            Add(new Order(1005, "Geert Smolders", new DateTime(2017, 1, 26), "Gray Jacket Long"));

        }
    }
}
