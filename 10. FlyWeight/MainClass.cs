public class MainClass
{
    static void Main(string[] args)
    {
        UnitTest();

        System.Console.ReadLine();
    }

    public static void UnitTest()
    {
        FlyWeightFactor theFactory = new FlyWeightFactor();

        theFactory.GetFlyWeight("1", "Shared Object 1");
        theFactory.GetFlyWeight("2", "Shared Object 2");
        theFactory.GetFlyWeight("3", "Shared Object 3");
    }
}
