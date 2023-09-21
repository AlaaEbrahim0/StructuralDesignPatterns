public class Circle : Dot
{
	private int radius;
	public Circle(int x, int y, int radius) : base(x, y)
	{
		this.radius = radius;
	}
	public override void Draw()
	{
		Console.WriteLine($"Drawing a circle with radius => {this.radius} on (x, y) => ({this.x}, {this.y})");
	}

}
