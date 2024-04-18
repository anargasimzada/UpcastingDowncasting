using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_task1.Models
{
    internal class Apple:Fruit
    {
        public int _VitaminA;
        public int _VitaminB;

        public Apple(int price, string sort, int vitaminA, int vitaminB) : base(price, sort)
        {
            _VitaminA = vitaminA;
            _VitaminB = vitaminB;
        }

        public override void Taste()
        {
            Console.WriteLine(" alma dadi verir");
        }
    }
}
