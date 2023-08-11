
namespace Adapter;

public class RoundHole
{
    public double Radius { get; private set; }

    public RoundHole(double radius)
    {
        Radius = radius;
    }

    public bool Fits(RoundPeg peg)
    {
        return this.Radius >= peg.Radius;
    }

    
}
