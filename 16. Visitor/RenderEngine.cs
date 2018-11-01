using System;

public abstract class RenderEngine
{
    public abstract void Render(string ObjName);
    public abstract void Text(string text);
}

public class DirectX : RenderEngine
{
    public override void Render(string ObjName)
    {
        DXRender(ObjName);
    }

    public override void Text(string text)
    {
        DXRender(text);
    }

    public void DXRender(string ObjName)
    {
        System.Console.WriteLine("DXRender: " + ObjName);
    }
}

public class OpenGL : RenderEngine
{
    public override void Render(string ObjName)
    {
        GLRender(ObjName);
    }

    public override void Text(string text)
    {
        GLRender(text);
    }

    public void GLRender(string ObjName)
    {
        System.Console.WriteLine("GLRender: " + ObjName);
    }
}

public abstract class IShape
{
    protected RenderEngine m_RenderEngine = null;
    protected string m_Position = "(0, 0, 0)";

    public void SetRenderEngine(RenderEngine theRenderEngine)
    {
        m_RenderEngine = theRenderEngine;
    }

    public abstract void Draw();
    public abstract int GetVectorCount();

    public abstract void RunVisitor(IShapeVisitor theVisitor);
}

public class Sphere : IShape
{
    public Sphere(RenderEngine theRenderEngine)
    {
        base.SetRenderEngine(theRenderEngine);
    }

    public override void Draw()
    {
        m_RenderEngine.Render("Sphere");
    }

    public override int GetVectorCount()
    {
        return 130;
    }

    public override void RunVisitor(IShapeVisitor theVisitor)
    {
        theVisitor.VisitSphere(this);
    }
}

public class Cube : IShape
{
    public Cube(RenderEngine theRenderEngine)
    {
        base.SetRenderEngine(theRenderEngine);
    }

    public override void Draw()
    {
        m_RenderEngine.Render("Cube");
    }

    public override int GetVectorCount()
    {
        return 300;
    }
    public override void RunVisitor(IShapeVisitor theVisitor)
    {
        theVisitor.VisitCube(this);
    }
}