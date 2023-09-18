using System.Text.RegularExpressions;
using Bridge.RemoteDevice;
using Bridge.ShapesRenderer.Abstractions;
using Bridge.ShapesRenderer.Implementors;

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

        //var circle = new Circle(3, new ScreenRenderer());
        //circle.Draw();

        //var square = new Square(3, new PaperRenderer());
        //square.Draw();

        // --------------------------------------------------------

        var tvDevice = new TV();
        var remote = new Remote(tvDevice);

        remote.TogglePower();
        remote.ChannelUp();
        remote.ChannelUp();

        remote.VolumeUp(200);


		Console.WriteLine(tvDevice);
    }
}
