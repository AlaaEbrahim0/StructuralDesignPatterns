using System.Text;
using Decorator.IceCreamShop.BeforeDecorator;

namespace Decorator.IceCreamShop.AfterDecorator;

public class IceCreamWithChocolateChipsDecorator : IceCreamBaseDecorator
{
	public IceCreamWithChocolateChipsDecorator(IceCreamComponent iceCream) : base(iceCream)
	{
	}

	public override StringBuilder Description => base.Description.Append("+ ChocolateChips");
	public override decimal CalculateCost() => base.CalculateCost() + .45m;
}

