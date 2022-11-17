using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Car
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int quantity { get; set; }
        public int unitPrice { get; set; }

        public Car(string brand, string model, int quantity, int unitPrice)
        {
            this.brand = brand;
            this.model = model;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }
    }
}
