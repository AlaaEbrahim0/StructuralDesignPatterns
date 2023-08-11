using Bridge.Implementors;

namespace Bridge.Abstractions;

public abstract class Shape
{
    protected readonly IRenderer renderer;

    public Shape(IRenderer renderer)
    {
        this.renderer = renderer;
    }
    public abstract void Draw();
}
