public class MainClass
{
    static void Main(string[] args)
    {
        UnitTest();

        System.Console.ReadLine();
    }

    public static void UnitTest()
    {
        Invoker theInvoker = new Invoker();

        Command theCommand = null;

        theCommand = new ConcreteCommand1(new Receiver1(), "HI");
        theInvoker.AddCommand(theCommand);

        theCommand = new ConcreteCommand2(new Receiver2(), 999);
        theInvoker.AddCommand(theCommand);

        theInvoker.ExecuteCommand();
    }
}
