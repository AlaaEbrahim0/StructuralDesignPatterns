using System.Text;
using Decorator.IceCreamShop.BeforeDecorator;

namespace Decorator.IceCreamShop.AfterDecorator;

public class IceCreamWithFruitMixDecorator : IceCreamBaseDecorator
{
	public IceCreamWithFruitMixDecorator(IceCreamComponent iceCream) : base(iceCream)
	{
	}

	public override StringBuilder Description => base.Description.Append("+ FruitMix");
	public override decimal CalculateCost() => base.CalculateCost() + .35m;
}

