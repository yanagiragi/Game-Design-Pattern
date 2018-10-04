public abstract class IShape
{
    protected RenderEngine m_RenderEngine = null;

    public void SetRenderEngine(RenderEngine theRenderEngine){
        m_RenderEngine = theRenderEngine;
    }

    public abstract void Draw();
}