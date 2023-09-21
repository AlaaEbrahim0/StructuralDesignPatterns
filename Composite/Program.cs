using System.Drawing;

public class Program
{
	private static void Main(string[] args)
	{
		/*
			Composite is a structural design pattern that lets you compose 
			objects into tree structures and then work with these trees 
			as if they were individual objects

			Using the Composite pattern makes sense only when the core
			model of your app can be represented as a tree
		 */

		var editor = new ImageEditor();
		editor.Load();
		editor.groupSelected(new List<Graphic>
		{
			new Dot(3, 2),
			new Dot(3, 4),
			new Circle(6, 3, 10)
		});


	}
}
