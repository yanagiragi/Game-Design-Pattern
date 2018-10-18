public class MainClass
{
    static void Main(string[] args)
    {
        UnitTest();

        System.Console.ReadLine();
    }

    public static void UnitTest()
    {
        OpenGL theOpenGL = new OpenGL();

        Sphere theSphere = new Sphere();
        theSphere.SetRenderEngine(theOpenGL);

        BorderDecorator theSphereWithBorder = new BorderDecorator(theSphere);
        theSphereWithBorder.SetRenderEngine(theOpenGL);
        theSphereWithBorder.Draw();

    }
}
