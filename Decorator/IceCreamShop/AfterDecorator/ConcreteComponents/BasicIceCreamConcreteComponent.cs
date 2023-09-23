using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.IceCreamShop.AfterDecorator.ConcreteComponents;

// Concrete Component

public class BasicIceCreamConcreteComponent : IceCreamComponent
{
    public override StringBuilder Description => new("Ice Cream ");
    public override decimal CalculateCost() => 3.5m;
    public override string ToString()
    {
        return
            $"Description: {Description}\n" +
            $"Cost: {CalculateCost().ToString("C")}";
    }
}
