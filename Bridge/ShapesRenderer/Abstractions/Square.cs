using Bridge.ShapesRenderer.Implementors;

namespace Bridge.ShapesRenderer.Abstractions;

public class Square : Shape
{
    private float side;

    public Square(float side, IRenderer renderer) : base(renderer)
    {
        this.side = side;
    }

    public override void Draw()
    {
        renderer.RenderSquare(side);
    }
}
