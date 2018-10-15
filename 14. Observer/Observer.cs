using System;

public abstract class Subject
{
    System.Collections.Generic.List<Observer> m_Observers = new System.Collections.Generic.List<Observer>();

    public void Attach(Observer theObserver)
    {
        m_Observers.Add(theObserver);
    }

    public void Detach(Observer theObserver)
    {
        m_Observers.Remove(theObserver);
    }

    public void Notify()
    {
        foreach (Observer theObserver in m_Observers)
            theObserver.Update();
    }
}

public class ConcreteSubject : Subject
{
    string m_SubjectState;

    public void SetState(string State)
    {
        m_SubjectState = State;
    }

    public string GetState()
    {
        return m_SubjectState;
    }
}

public abstract class Observer
{
    public abstract void Update();
}

public class ConcreteObserver1 : Observer
{
    string m_ObjectState;

    ConcreteSubject m_Subject = null;

    public ConcreteObserver1(ConcreteSubject theSubject)
    {
        m_Subject = theSubject;
    }

    public override void Update()
    {
        System.Console.WriteLine("ConcreteObserver1.Update");

        m_ObjectState = m_Subject.GetState();
    }

    public void ShowState()
    {
        System.Console.WriteLine("ConcreteObserver1.Subject = " + m_ObjectState);
    }
}

public class ConcreteObserver2 : Observer
{
    ConcreteSubject m_Subject = null;

    public ConcreteObserver2(ConcreteSubject theSubject)
    {
        m_Subject = theSubject;
    }

    public override void Update()
    {
        System.Console.WriteLine("ConcreteObserver2.Update");

        System.Console.WriteLine("ConcreteObserver2.Subject = " + m_Subject.GetState());
    }
    
}