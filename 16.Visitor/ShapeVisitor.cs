public abstract class IShapeVisitor
{
    public virtual void VisitSphere(Sphere theSphere) { }
    public virtual void VisitCube(Cube theCube) { }
}

public class ShapeContainer
{
    System.Collections.Generic.List<IShape> m_Shapes = new System.Collections.Generic.List<IShape>();

    public ShapeContainer() { }

    public void AddShape(IShape theShape)
    {
        m_Shapes.Add(theShape);
    }

    public void RunVisitor(IShapeVisitor theVisitor)
    {
        foreach (IShape theShape in m_Shapes)
            theShape.RunVisitor(theVisitor);
    }
}

public class DrawVisitor : IShapeVisitor
{
    public override void VisitSphere(Sphere theSphere)
    {
        theSphere.Draw();
    }

    public override void VisitCube(Cube theCube)
    {
        theCube.Draw();
    }
}

public class VertexCountVisitor : IShapeVisitor
{
    public int Count = 0;
    public override void VisitSphere(Sphere theSphere)
    {
        Count += theSphere.GetVectorCount();
    }

    public override void VisitCube(Cube theCube)
    {
        Count += theCube.GetVectorCount();
    }
}