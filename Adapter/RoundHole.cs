using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
