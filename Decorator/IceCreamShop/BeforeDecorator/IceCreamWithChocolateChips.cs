using System.Text;

namespace Decorator.IceCreamShop.BeforeDecorator;

public class IceCreamWithChocolateChips : IceCream
{
	public override StringBuilder Description =>
		base.Description.Append("+ ChocolateChips");

	public override decimal CalculateCost() =>
		base.CalculateCost() + .45m;

}
