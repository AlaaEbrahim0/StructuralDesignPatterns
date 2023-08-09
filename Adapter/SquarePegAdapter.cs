using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter;

public class SquarePegAdapter: RoundPeg
{
    private SquarePeg squarePeg;

    public SquarePegAdapter(SquarePeg squarePeg): base(0)
    {
        this.squarePeg = squarePeg;
    }

    public override double Radius => squarePeg.Width * Math.Sqrt(2) / 2;


}
