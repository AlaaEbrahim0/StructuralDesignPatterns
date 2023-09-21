public class CompositeGraphic : Graphic
{
	private List<Graphic> graphics = new();
	public void Add(Graphic graphic)
	{
		graphics.Add(graphic);
	}
	public void Remove(Graphic graphic)
	{
		graphics.Remove(graphic);
	}

    public void Draw()
	{
		foreach (Graphic graphic in graphics)
		{
			graphic.Draw();
		}
	}

	public void Move(int x, int y)
	{
		foreach(Graphic graphic in graphics)
		{
			graphic.Move(x, y);
		}
	}
}
