
namespace Adapter;

public class RoundPeg
{
    public virtual double Radius { get; private set; }

    public RoundPeg(double radius)
    {
        Radius = radius;
    }


}
