namespace Bridge.ShapesRenderer.Implementors;

public interface IRenderer
{
    void RenderCircle(float radius);
    void RenderSquare(float side);
    void RenderTriangle(float side);
}
