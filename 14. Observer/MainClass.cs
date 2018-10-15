public class MainClass
{
    static void Main(string[] args)
    {
        UnitTest();

        System.Console.ReadLine();
    }

    public static void UnitTest()
    {
        ConcreteSubject theSubject = new ConcreteSubject();
        ConcreteObserver1 theObserver1 = new ConcreteObserver1(theSubject);
        theSubject.Attach(theObserver1);

        theSubject.Attach(new ConcreteObserver2(theSubject));

        theSubject.SetState("Subject Stat 1");

        // Simulate Update Call in GameLoop
        theSubject.Notify();

        theObserver1.ShowState();
    }
}
