using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Components;

namespace BuilderPattern
{
    public class ComputerBuilder
    {
        private CPU _cpu;
        private Motherboard _motherboard;
        private RAM _ram;
        private Storage _storage;
        private GPU _gpu;

        public ComputerBuilder SetCPU(string model)
        {
            _cpu = new CPU(model);
            return this;
        }

        public ComputerBuilder SetMotherboard(string model)
        {
            _motherboard = new Motherboard(model);
            return this;
        }

        public ComputerBuilder SetRAM(int sizeGB)
        {
            _ram = new RAM(sizeGB);
            return this;
        }

        public ComputerBuilder SetStorage(string type, int sizeGB)
        {
            _storage = new Storage(type, sizeGB);
            return this;
        }

        public ComputerBuilder SetGPU(string model)
        {
            _gpu = new GPU(model);
            return this;
        }

        public Computer Build()
        {
            return new Computer(_cpu, _motherboard, _ram, _storage, _gpu);
        }
    }
}
