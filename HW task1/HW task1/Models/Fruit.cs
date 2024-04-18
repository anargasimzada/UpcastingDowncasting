using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_task1.Models
{
    internal abstract class Fruit
    {
        public int _Price;
        public string _Sort;


        public Fruit(int price, string sort)
        {
            _Price = price;
            _Sort = sort;
        }

        public abstract void Taste();
    }
}
