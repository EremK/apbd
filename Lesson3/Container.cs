namespace Lesson3;

public abstract class Container
{
    public double CargoMass { get; set; }
    public int Height { get; set; }
    public double TareWeight { get; set; }
    public int Depth { get; set; }
    public string SerialNumber { get; set; }
    public double MaxPayload { get; set; }

    public abstract void LoadCargo(double mass);
    public abstract void UnloadCargo();
}
