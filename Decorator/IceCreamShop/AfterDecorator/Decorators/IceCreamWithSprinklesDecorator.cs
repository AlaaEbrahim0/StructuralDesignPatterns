using System.Text;
using Decorator.IceCreamShop.BeforeDecorator;

namespace Decorator.IceCreamShop.AfterDecorator;

public class IceCreamWithSprinklesDecorator : IceCreamBaseDecorator
{
	public IceCreamWithSprinklesDecorator(IceCreamComponent iceCream) : base(iceCream)
	{
	}

	public override StringBuilder Description => base.Description.Append("+ Sprinkles");
	public override decimal CalculateCost() => base.CalculateCost() + .25m;
}

