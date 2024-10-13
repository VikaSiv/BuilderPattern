using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Components
{
    public class Storage
    {
        public string Type { get; }
        public int SizeGB { get; }

        public Storage(string type, int sizeGB)
        {
            Type = type;
            SizeGB = sizeGB;
        }
    }
}
