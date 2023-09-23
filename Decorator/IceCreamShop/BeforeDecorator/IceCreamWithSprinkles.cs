using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.IceCreamShop.BeforeDecorator;
public class IceCreamWithSprinkles: IceCream
{
	public override StringBuilder Description => 
		base.Description.Append("+ Sprinkles");

	public override decimal CalculateCost() => 
		base.CalculateCost() + .25m;
	
}
