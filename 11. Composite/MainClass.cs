public class MainClass
{
    static void Main(string[] args)
    {
        UnitTest();

        System.Console.ReadLine();
    }

    public static void UnitTest()
    {
        IComponent theRoot = new Composite("Root");

        theRoot.Add(new Leaf("Leaf1"));
        theRoot.Add(new Leaf("Leaf2"));

        IComponent theChild1 = new Composite("Child1");
        theChild1.Add(new Leaf("Child1.Leaf1"));
        theChild1.Add(new Leaf("Child1.Leaf2"));
        theRoot.Add(theChild1);

        IComponent theChild2 = new Composite("Child2");
        theChild2.Add(new Leaf("Child2.Leaf1"));
        theChild2.Add(new Leaf("Child2.Leaf2"));
        theChild2.Add(new Leaf("Child2.Leaf3"));
        theRoot.Add(theChild2);

        theRoot.Operation();
    }
}
