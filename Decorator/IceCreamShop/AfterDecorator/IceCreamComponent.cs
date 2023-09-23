using System.Text;

namespace Decorator.IceCreamShop.AfterDecorator;

public abstract class IceCreamComponent
{
    public abstract StringBuilder Description { get; }
    public abstract decimal CalculateCost();
    public override string ToString()
    {
        return
            $"Description: {Description}\n" +
            $"Cost: {CalculateCost().ToString("C")}";
    }
}
