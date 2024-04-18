using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_task2.Models
{
    internal class Lion:Animal
    {
        public bool _IsPrideLeader { get; set; } = true;

        public Lion(string breed, bool isPrideLeader)
        {
            Breed = breed;
            _IsPrideLeader = isPrideLeader;
        }

        public override void EatFood(Food food)
        {
            if (food is Meat)
            {
                Console.WriteLine(" ugurla qidalandi");
            }
            else
            {
                Console.WriteLine("yanlisdir");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("wogf");
        }
    }
}
