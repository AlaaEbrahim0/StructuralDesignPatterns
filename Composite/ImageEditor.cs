public class ImageEditor
{
	private CompositeGraphic all;
	public void Load()
	{
		all = new CompositeGraphic();
		all.Add(new Dot(1, 2));
		all.Add(new Circle(5, 3, 10));
	}

	public void groupSelected(List<Graphic> graphics)
	{
		var group = new CompositeGraphic();
		foreach (Graphic g in graphics)
		{
			group.Add(g);
			all.Remove(g);
		}
		all.Add(group);
		all.Draw();
	}
}