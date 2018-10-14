public class MainClass
{
    static void Main(string[] args)
    {
        UnitTest();

        System.Console.ReadLine();
    }

    public static void UnitTest()
    {
        Director theDirector = new Director();
        Product theProduct = null;

        theDirector.Constrcut(new ConcreteBuilderA());
        theProduct = theDirector.GetResult();
        theProduct.ShowProduct();

        theDirector.Constrcut(new ConcreteBuilderB());
        theProduct = theDirector.GetResult();
        theProduct.ShowProduct();
    }
}
