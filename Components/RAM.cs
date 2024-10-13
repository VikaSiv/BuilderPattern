using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Components
{
    public class RAM
    {
        public int SizeGB { get; }

        public RAM(int sizeGB)
        {
            SizeGB = sizeGB;
        }
    }
}
