using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter;

public class RoundPeg
{
    public virtual double Radius { get; private set; }

    public RoundPeg(double radius)
    {
        Radius = radius;
    }


}
