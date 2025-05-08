using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farma_Joko
{
    internal class Upgrade
    {
        public string name { get; }
        public string description { get; }
        public int price { get; }
        public float multiplier { get; }
        public bool isBought { get; set; }
        public Upgrade(string name, string description, int price, float multiplier)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.multiplier = multiplier;
            isBought = false;
        }
    }
}
