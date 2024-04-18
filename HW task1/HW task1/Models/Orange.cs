using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_task1.Models
{
    internal class Orange:Fruit
    {
        public int _VitaminC;

        public Orange(int price, string sort, int vitaminC) : base(price, sort)
        {
            _VitaminC = vitaminC;
        }

        public override void Taste()
        {
            Console.WriteLine("Orange dadi verir ");
        }
    }
}
