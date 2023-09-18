using Bridge.ShapesRenderer.Implementors;

namespace Bridge.ShapesRenderer.Abstractions;

public class Circle : Shape
{
    private float radius;

    public Circle(float radius, IRenderer renderer) : base(renderer)
    {
        this.radius = radius;
    }

    public override void Draw()
    {
        renderer.RenderCircle(radius);
    }
}
