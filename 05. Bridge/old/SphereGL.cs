public class SphereGL : ISphere
{
    OpenGL m_OpenGL;

    public override void Draw()
    {
        m_OpenGL.GLRender("Sphere");
    }
}