public class MainClass
{
    public static void Main(string[] args)
    {
        UnitTest();

        System.Console.ReadLine();
    }

    public static void UnitTest()
    {
        System.Console.WriteLine("Basic Factory Method");

        Product theProduct = null;

        Creator theCreator = null;

        theCreator = new ConcreteCreatorProductA();
        theProduct = theCreator.FactoryMethod();

        theCreator = new ConcreteCreatorProductB();
        theProduct = theCreator.FactoryMethod();

        System.Console.WriteLine("\nMethod_type Factory Method");

        ConcreteCreator_MethodType theCreatorMethodType = new ConcreteCreator_MethodType();
        theProduct = theCreatorMethodType.FactoryMethod(1);
        theProduct = theCreatorMethodType.FactoryMethod(2);

        System.Console.WriteLine("\nGeneric Class Factory Method");

        Creator_GenericClass<ConcreteProductA> Creator_ProductA = new Creator_GenericClass<ConcreteProductA>();
        theProduct = Creator_ProductA.FactoryMethod();

        Creator_GenericClass<ConcreteProductB> Creator_ProductB = new Creator_GenericClass<ConcreteProductB>();
        theProduct = Creator_ProductB.FactoryMethod();

        System.Console.WriteLine("\nGeneric Method Factory Method");
        ConcreteCreator_GenericMethod theCreatorGM = new ConcreteCreator_GenericMethod();
        theProduct = theCreatorGM.FactoryMethod<ConcreteProductA>();
        theProduct = theCreatorGM.FactoryMethod<ConcreteProductB>();
    }
}