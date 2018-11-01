public abstract class Target
{
    public abstract void Request();
}

public class Adaptee
{
    public Adaptee() { }

    public void SpecificRequest()
    {
        System.Console.WriteLine("Call Adaptee.SpecificRequest");
    }
}

public class Adapter : Target
{
    public Adaptee m_Adaptee = new Adaptee();

    public Adapter() { }

    public override void Request()
    {
        m_Adaptee.SpecificRequest();
    }
}