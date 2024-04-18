using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_task1.Models
{
    internal class Pineapple:Fruit
    {
        public int _VitaminE;
        public int _VitaminD;

        public Pineapple(int price, string sort, int vitaminE, int vitaminD) : base(price, sort)
        {
            _VitaminE = vitaminE;
            _VitaminD = vitaminD;
        }

        public override void Taste()
        {
            Console.WriteLine("Pineapple dadi verir ");
        }
    }
}
