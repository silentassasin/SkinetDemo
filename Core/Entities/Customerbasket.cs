using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Customerbasket
    {
        public Customerbasket()
        {
        }

        public Customerbasket(string id)
        {
            Id = id;
         
        }

        public string Id { get; set; }

        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
    }
}