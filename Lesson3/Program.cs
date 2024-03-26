using Lesson3;

class Program
{
    static void Main(string[] args)
    {
        RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer();
        refrigeratedContainer.SerialNumber = "KON-C-1";
        refrigeratedContainer.MaxPayload = 2000;
        refrigeratedContainer.LoadCargo(900);

        LiquidContainer liquidContainer = new LiquidContainer();
        liquidContainer.SerialNumber = "KON-C-2";
        liquidContainer.MaxPayload = 5000;
        liquidContainer.IsHazardous = false;
        liquidContainer.LoadCargo(1450);

        GasContainer gasContainer = new GasContainer();
        gasContainer.SerialNumber = "KON-C-3";
        gasContainer.MaxPayload = 1900;
        gasContainer.LoadCargo(500);
        
        List<Container> containers = new List<Container>();
        containers.Add(refrigeratedContainer);
        containers.Add(liquidContainer);
        containers.Add(gasContainer);
        
        Console.WriteLine("Info about containers on the ship: :");
        foreach (var container in containers)
        {
            Console.WriteLine("+ " + container.GetType().Name + " -> number: " + container.SerialNumber + ", cargo: " + container.CargoMass + "kg");
        }
    }
}