using System;
using BuilderPattern;

class Program
{
    static void Main(string[] args)
    {
        ComputerBuilder builder = new ComputerBuilder();

        Computer myComputer = builder
            .SetCPU("Intel Core i7")
            .SetMotherboard("ASUS ROG STRIX")
            .SetRAM(16)
            .SetStorage("SSD", 512)
            .SetGPU("NVIDIA RTX 3080")
            .Build();

        myComputer.ShowSpecs();

        Console.ReadLine();
    }
}
