using System;

public class MainClass
{
    public static void Main(String[] args)
    {
        UnitTest();

        Console.ReadLine();
    }

    public static void UnitTest()
    {
        Context theContext = new Context();

        theContext.SetStrategy(new ConcreteStrategyA());
        theContext.ContextInterface();

        theContext.SetStrategy(new ConcreteStrategyB());
        theContext.ContextInterface();
    }
}