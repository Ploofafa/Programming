using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    public class Cart
    {
        private List<Item> _items;

        public Cart()
        {
        }

        public Cart(List<Item> items)
        {
            _items = items;
        }

        public List<Item> Items { get; set; }

        public double Amount
        {
            set
            {
                if (_items.Count != 0 || _items == null)
                {
                    for (int i = 0; i < _items.Count; i++)
                    {
                        _items[i].Cost += value;
                    }
                }
                else
                {
                    value = 0.0;
                }
                Amount = value;
            }
        }
    }
}
