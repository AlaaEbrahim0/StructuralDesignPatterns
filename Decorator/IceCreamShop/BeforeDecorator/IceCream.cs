using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.IceCreamShop.BeforeDecorator;
public class IceCream
{
    public virtual StringBuilder Description => new("Ice Cream ");
    public virtual decimal CalculateCost() => 3.5m;
    public override string ToString()
    {
        return
            $"Description: {Description}\n" +
            $"Cost: {CalculateCost().ToString("C")}";
    }
}




