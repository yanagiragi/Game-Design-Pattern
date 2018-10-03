using System;

public class MainClass
{
    static void Main(string[] args)
    {
        MainClass.UnitTest();

        Console.ReadLine();
    }

    public static void UnitTest()
    {
        Console.WriteLine("Start Unit Test");

        ConcreteMediator pMediator = new ConcreteMediator();

        ConcreteColleague1 pColleague1 = new ConcreteColleague1(pMediator);
        ConcreteColleague2 pColleague2 = new ConcreteColleague2(pMediator);

        pMediator.SetColleague1(pColleague1);
        pMediator.SetColleague2(pColleague2);

        pColleague1.Action();
        pColleague2.Action();
    }
}