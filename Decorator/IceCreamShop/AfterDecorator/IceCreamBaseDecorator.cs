using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Decorator.IceCreamShop.BeforeDecorator;

namespace Decorator.IceCreamShop.AfterDecorator;
public abstract class IceCreamBaseDecorator: IceCreamComponent
{
	private IceCreamComponent _iceCream;

	public IceCreamBaseDecorator(IceCreamComponent iceCream)
	{
		_iceCream = iceCream;
	}

	public override StringBuilder Description => _iceCream.Description;

	public override decimal CalculateCost() => _iceCream.CalculateCost();
}

