using System;

public class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(Mediator theMediator) : base(theMediator) { }

    public void Action()
    {
        // 執行後通知其他 Colleague
        m_Mediator.SendMessage(this, "Colleague1 Send A Message");
    }

    public override void Request(string Message)
    {
        Console.WriteLine("ConcreteColleague1.Request: " + Message);
    }
}


public class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(Mediator theMediator) : base(theMediator) { }

    public void Action()
    {
        m_Mediator.SendMessage(this, "Colleague2 Send A Message");
    }

    public override void Request(string Message)
    {
        Console.WriteLine("ConcreteColleague2.Request: " + Message);
    }
}
