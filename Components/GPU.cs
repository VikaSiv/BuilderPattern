using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Components
{
    public class GPU
    {
        public string Model { get; }

        public GPU(string model)
        {
            Model = model;
        }
    }
}
