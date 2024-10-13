using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Components
{
    public class Motherboard
    {
        public string Model { get; }

        public Motherboard(string model)
        {
            Model = model;
        }
    }
}
