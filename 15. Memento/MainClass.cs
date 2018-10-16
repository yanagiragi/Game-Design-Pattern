public class MainClass
{
    static void Main(string[] args)
    {
        UnitTest();

        System.Console.ReadLine();
    }

    public static void UnitTest()
    {
        Originator theOriginator = new Originator();
        Caretaker theCaretaker = new Caretaker();

        theOriginator.SetInfo("Version1");
        theOriginator.ShowInfo();
        theCaretaker.AddMemento("1", theOriginator.CreateMemento());

        theOriginator.SetInfo("Version2");
        theOriginator.ShowInfo();
        theCaretaker.AddMemento("2", theOriginator.CreateMemento());

        theOriginator.SetInfo("Version3");
        theOriginator.ShowInfo();
        theCaretaker.AddMemento("3", theOriginator.CreateMemento());

        // Fallback to version 2
        theOriginator.SetMemento(theCaretaker.GetMemento("2"));
        theOriginator.ShowInfo();
    }
}
