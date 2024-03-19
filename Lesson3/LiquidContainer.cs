namespace Lesson3;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazardous { get; set; }

    public override void LoadCargo(double mass)
    {
        double maxMass = 0;

        if (IsHazardous)
        {
            maxMass = MaxPayload * 0.5;
        }
        else
        {
            maxMass = MaxPayload * 0.9;
        }
        
        if (mass > maxMass)
        {
            throw new OverfillException("An attempt to overfill a liquid container was spotted.");
        }

        CargoMass = mass;
    }

    public override void UnloadCargo()
    {
        CargoMass = 0;
    }

    public void SendHazardNotification(string message)
    {
        Console.WriteLine("Hazard! Serial number: " + SerialNumber + ", description" + message);
    }
}
