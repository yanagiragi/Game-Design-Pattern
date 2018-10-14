using System;

public class Program
{
    static void Main(string[] args)
    {
        UnitTest();

        Console.ReadLine();
    }

    static void UnitTest()
    {
        AbstractClass theClass = new ConcreteClassA();
        theClass.TemplateMethod();

        theClass = new ConcreteClassB();
        theClass.TemplateMethod();
    }
}

