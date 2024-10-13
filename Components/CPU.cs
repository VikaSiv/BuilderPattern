using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Components
{
    public class CPU
    {
        public string Model { get; }

        public CPU(string model)
        {
            Model = model;
        }
    }
}
