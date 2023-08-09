using System.Xml;

namespace Adapter;

internal class Program
{
    static void Main(string[] args)
    {
        var hole = new RoundHole(5);

        var smallRoundPeg = new RoundPeg(3);
        // 3 <= 5 : TRUE
        Console.WriteLine(hole.Fits(smallRoundPeg));


        var smallSquarePeg = new SquarePeg(5);
        var largeSquarePeg = new SquarePeg(10);


        var smallSquarePegAdapter = new SquarePegAdapter(smallSquarePeg);
        var largeSquarePegAdapter = new SquarePegAdapter(largeSquarePeg);

        // 5 <= 5 : TRUE
        Console.WriteLine(hole.Fits(smallSquarePegAdapter));

        // 10 <= 5 : FALSE
        Console.WriteLine(hole.Fits(largeSquarePegAdapter));


    }
}
