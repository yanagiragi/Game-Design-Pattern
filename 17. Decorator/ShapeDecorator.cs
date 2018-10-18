using System;

public abstract class IAdditional
{
    protected RenderEngine m_RenderEngine = null;

    public void SetRenderEngine(RenderEngine theRenderEngine)
    {
        m_RenderEngine = theRenderEngine;
    }

    public abstract void DrawOnShape(IShape theShape);
}

public class Border : IAdditional
{
    public override void DrawOnShape(IShape theShape)
    {
        m_RenderEngine.Render("Draw Border for Vector Count " + theShape.GetVectorCount());
    }
}

public class IShapeDecorator : IShape
{
    IShape m_Component;

    public IShapeDecorator(IShape theComponent)
    {
        m_Component = theComponent;
    }

    public override void Draw()
    {
        m_Component.Draw();
    }

    public override int GetVectorCount()
    {
        return m_Component.GetVectorCount();
    }
}

public class BorderDecorator : IShapeDecorator
{
    Border m_Border = new Border();

    public BorderDecorator(IShape theComponent) : base(theComponent) { }

    public virtual void SetRenderEngine(RenderEngine theRenderEngine)
    {
        base.SetRenderEngine(theRenderEngine);
        m_Border.SetRenderEngine(theRenderEngine);
    }

    public override void Draw()
    {
        base.Draw();
        m_Border.DrawOnShape(this);
    }

}