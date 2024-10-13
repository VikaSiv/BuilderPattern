using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Components;

namespace BuilderPattern
{
    public class Computer
    {
        public CPU Cpu { get; private set; }
        public Motherboard Motherboard { get; private set; }
        public RAM Ram { get; private set; }
        public Storage Storage { get; private set; }
        public GPU Gpu { get; private set; }

        public Computer(CPU cpu, Motherboard motherboard, RAM ram, Storage storage, GPU gpu)
        {
            Cpu = cpu;
            Motherboard = motherboard;
            Ram = ram;
            Storage = storage;
            Gpu = gpu;
        }

        public void ShowSpecs()
        {
            Console.WriteLine("Computer specifications:");
            Console.WriteLine($"CPU: {Cpu.Model}");
            Console.WriteLine($"Motherboard: {Motherboard.Model}");
            Console.WriteLine($"RAM: {Ram.SizeGB} GB");
            Console.WriteLine($"Storage: {Storage.SizeGB} GB {Storage.Type}");
            Console.WriteLine($"GPU: {Gpu.Model}");
        }
    }
}
