public class MainClass
{
    static void Main(string[] args)
    {
        UnitTest();

        System.Console.ReadLine();
    }

    public static void UnitTest()
    {
        DirectX theDirectX = new DirectX();

        ShapeContainer theShapeContainer = new ShapeContainer();

        theShapeContainer.AddShape(new Cube(theDirectX));
        theShapeContainer.AddShape(new Sphere(theDirectX));

        theShapeContainer.RunVisitor(new DrawVisitor());

        VertexCountVisitor theVectorCount = new VertexCountVisitor();
        theShapeContainer.RunVisitor(theVectorCount);

        System.Console.WriteLine("Vertex Count: " + theVectorCount.Count);
    }
}
