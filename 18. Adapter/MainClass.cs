public class MainClass
{
    static void Main(string[] args)
    {
        UnitTest();

        System.Console.ReadLine();
    }

    public static void UnitTest()
    {
        Target theTarget = new Adapter();
        theTarget.Request();
    }
}
