public class Dot : Graphic
{
	protected int x;
	protected int y;

	public Dot(int x, int y)
    {
        this.x = x;
		this.y = y;
    }
    public virtual void Draw()
	{
        Console.WriteLine($"Drawing a dot on (x, y) => ({x}, {y})");
    }

	public void Move(int x, int y)
	{
		this.x += x;
		this.y += y;
	}
}
