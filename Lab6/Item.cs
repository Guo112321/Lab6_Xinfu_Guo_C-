using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Item
    {
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Item(int itemNo, string description, double price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return ItemNo + "|" + Description + "|" + Price;
        }
    }
}
