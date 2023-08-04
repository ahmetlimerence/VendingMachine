using System.Reflection.PortableExecutable;
using VendingMachine;

internal class Program
{
    private static void Main(string[] args)
    {
        VendingMachine.Machine _machine = new VendingMachine.Machine();
        _machine.GiveProduct(1);
    }
  
}