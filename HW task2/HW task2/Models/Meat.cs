using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_task2.Models
{
    internal class Meat:Food
    {
        public string Type { get; set; }

        public Meat(string type, int calorie) : base(calorie)
        {
            Type = type;
        }
    }
}
