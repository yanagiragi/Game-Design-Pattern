public class Hander
{
    protected Hander m_NextHandler = null;

    public Hander(Hander theNextHandler)
    {
        m_NextHandler = theNextHandler;
    }

    public virtual void HandleRequest(int cost)
    {
        if (m_NextHandler != null)
            m_NextHandler.HandleRequest(cost);
    }
}

public class ConcreteHandler1 : Hander
{
    private int m_CostCheck = 10;

    public ConcreteHandler1(Hander theNextHandler) : base(theNextHandler) { }

    public override void HandleRequest(int cost)
    {
        if (cost <= m_CostCheck)
            System.Console.WriteLine("ConcreteHandler1.HandleRequst Pass");
        else
            base.HandleRequest(cost);
    }
}

public class ConcreteHandler2 : Hander
{
    private int m_CostCheck = 20;

    public ConcreteHandler2(Hander theNextHandler) : base(theNextHandler) { }

    public override void HandleRequest(int cost)
    {
        if (cost <= m_CostCheck)
            System.Console.WriteLine("ConcreteHandler2.HandleRequst Pass");
        else
            base.HandleRequest(cost);
    }
}

public class ConcreteHandler3 : Hander
{
    public ConcreteHandler3(Hander theNextHandler) : base(theNextHandler) { }

    public override void HandleRequest(int cost)
    {
        System.Console.WriteLine("ConcreteHandler3.HandleRequst Pass");        
    }
}