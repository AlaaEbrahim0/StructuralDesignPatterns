using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter;

public class SquarePeg
{
    public double Width { get; private set; }

    public SquarePeg(double width)
    {
        Width = width;
    }

}
