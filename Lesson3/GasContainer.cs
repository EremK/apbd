namespace Lesson3;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }

    public override void LoadCargo(double mass)
    {
        if (mass > MaxPayload)
        {
            throw new OverfillException("An attempt to overfill a liquid container was spotted.");
        }

        CargoMass = mass;
    }

    public override void UnloadCargo()
    {
        CargoMass = MaxPayload * 0.05; 
    }

    public void SendHazardNotification(string message)
    {
        Console.WriteLine("Hazard! Serial number: " + SerialNumber + ", description" + message);
    }
}
