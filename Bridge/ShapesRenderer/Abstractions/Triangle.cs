using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.ShapesRenderer.Implementors;

namespace Bridge.ShapesRenderer.Abstractions;

public class Triangle : Shape
{
    private float side;

    public Triangle(float side, IRenderer renderer) : base(renderer)
    {
        this.side = side;
    }
    public override void Draw()
    {
        renderer.RenderTriangle(side);
    }
}
