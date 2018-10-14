public class MainClass
{
    static void Main(string[] args)
    {
        UnitTest();

        System.Console.ReadLine();
    }

    public static void UnitTest()
    {
        ConcreteHandler3 theHandler3 = new ConcreteHandler3(null);
        ConcreteHandler2 theHandler2 = new ConcreteHandler2(theHandler3);
        ConcreteHandler1 theHandler1 = new ConcreteHandler1(theHandler2);

        theHandler1.HandleRequest(10);
        theHandler1.HandleRequest(15);
        theHandler1.HandleRequest(20);
        theHandler1.HandleRequest(30);
        theHandler1.HandleRequest(100);
    }
}
