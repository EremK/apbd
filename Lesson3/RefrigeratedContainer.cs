namespace Lesson3;

public class RefrigeratedContainer : Container
{
    public string ProductType { get; set; }
    public double Temperature { get; set; }

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
        CargoMass = 0;
    }
}