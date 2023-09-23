using System.Text;

namespace Decorator.IceCreamShop.BeforeDecorator;

public class IceCreamWithFruitMix : IceCream
{
	public override StringBuilder Description =>
		base.Description.Append("+ FruitMix");

	public override decimal CalculateCost() =>
		base.CalculateCost() + .35m;

}
