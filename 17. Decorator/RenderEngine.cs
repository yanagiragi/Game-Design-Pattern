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
}

public class Sphere : IShape
{
    public Sphere()
    {

    }

    public override void Draw()
    {
        m_RenderEngine.Render("Sphere");
    }

    public override int GetVectorCount()
    {
        return 130;
    }
}
