public abstract class Colleague
{
    protected Mediator m_Mediator = null;

	public Colleague(Mediator theMediator)
	{
        m_Mediator = theMediator;	
	}

    public abstract void Request(string Message);
}
