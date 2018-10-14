public abstract class RenderEngine
{
    public abstract void Render(String ObjName);
}

public class DirectX : RenderEngine
{
    public override void Render(String ObjName){
        DXRender(ObjName);
    }

    public void DXRender(string ObjName)
    {
        Console.WriteLine("DXRender: " + ObjName);
    }
}

public class OpenGL : RenderEngine
{
    public override void Render(String ObjName){
        GLRender(ObjName);
    }

    public void GLRender(string ObjName)
    {
        Console.WriteLine("GLRender: " + ObjName);
    }
}