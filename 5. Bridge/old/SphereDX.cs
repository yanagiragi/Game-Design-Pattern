public class SphereDX : ISphere
{
    DirectX m_DirectX;

    public override void Draw()
    {
        m_DirectX.DXRender("Sphere");
    }
}