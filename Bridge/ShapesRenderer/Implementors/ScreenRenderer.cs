namespace Bridge.ShapesRenderer.Implementors;

public class ScreenRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing a circle on the screen with radius {radius}.");
    }

    public void RenderSquare(float side)
    {
        Console.WriteLine($"Drawing a square on the screen with side {side}.");
    }

    public void RenderTriangle(float side)
    {
        Console.WriteLine($"Drawing a triangle on the screen with side {side}.");
    }
}
