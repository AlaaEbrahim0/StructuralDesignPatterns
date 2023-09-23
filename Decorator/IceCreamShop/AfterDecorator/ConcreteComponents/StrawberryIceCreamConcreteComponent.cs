using System.Text;

namespace Decorator.IceCreamShop.AfterDecorator.ConcreteComponents;

public class StrawberryIceCreamConcreteComponent : IceCreamComponent
{
    public override StringBuilder Description => new("Strawyberry Ice Cream ");
    public override decimal CalculateCost() => 3.5m;
    public override string ToString()
    {
        return
            $"Description: {Description}\n" +
            $"Cost: {CalculateCost().ToString("C")}";
    }
}