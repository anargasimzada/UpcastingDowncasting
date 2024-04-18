using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_task2.Models
{
    internal class Food
    {
        public int _calorie { get; set; } = 1200;

        public Food(int calorie)
        {
            _calorie = calorie;
        }
    }
}
