using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchy
{
    internal class Apple
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Apple(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}
