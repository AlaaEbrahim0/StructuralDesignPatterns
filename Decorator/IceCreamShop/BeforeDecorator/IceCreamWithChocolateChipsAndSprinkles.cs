using System.Text;

namespace Decorator.IceCreamShop.BeforeDecorator;

public class IceCreamWithChocolateChipsAndSprinkles : IceCream
{
	public override StringBuilder Description =>
		base.Description.Append("+ ChocolateChips + Sprinkles");

	public override decimal CalculateCost() =>
		base.CalculateCost() +.70m;

}
