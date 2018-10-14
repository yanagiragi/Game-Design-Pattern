
using System;

public class ConcreteMediator : Mediator
{
    ConcreteColleague1 m_Colleague1 = null;
    ConcreteColleague2 m_Colleague2 = null;

    public void SetColleague1(ConcreteColleague1 theColleague)
    {
        m_Colleague1 = theColleague;
    }

    public void SetColleague2(ConcreteColleague2 theColleague)
    {
        m_Colleague2 = theColleague;
    }

    public override void SendMessage(Colleague theColleague, string Message)
    {
        if(m_Colleague1 == theColleague)
        {
            m_Colleague2.Request(Message);
        }

        if (m_Colleague2 == theColleague)
        {
            m_Colleague1.Request(Message);
        }
    }
}

