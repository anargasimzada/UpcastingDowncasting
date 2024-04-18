using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_task2.Models
{
    internal class Grass:Food
    {
        public string Name { get; set; }

        public Grass(string name, int calorie) : base(calorie)
        {
            Name = name;
        }
    }
}
