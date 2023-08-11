using System.ComponentModel.DataAnnotations;

namespace Bridge;

public class Program
{
    static void Main(string[] args)
    {
        /*
            Bridge is a structural design pattern that lets you split a large
            class or a set of closely related classes into two separate
            hierarchies—abstraction and implementation—which can be
            developed independently of each other.
        */
        var circle = new Circle(3, new ScreenRenderer());
        circle.Draw();

        var square = new Square(3, new PaperRenderer());
        square.Draw();
        
    }
}
