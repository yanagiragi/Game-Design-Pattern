using System;

public abstract class IComponent
{
    protected string m_Value;

    public abstract void Operation();

    public virtual void Add(IComponent theComponent)
    {
        System.Console.WriteLine("Child Not Implemented");
    }

    public virtual void Remove(IComponent theComponent)
    {
        System.Console.WriteLine("Child Not Implemented");
    }

    public virtual IComponent GetChild(int Index)
    {
        System.Console.WriteLine("Child Not Implemented");
        return null;
    }
}

public class Composite : IComponent
{
    System.Collections.Generic.List<IComponent> m_Childs = new System.Collections.Generic.List<IComponent>();

    public Composite (string value)
    {
        m_Value = value;
    }

    public override void Operation()
    {
        System.Console.WriteLine("Composite [" + m_Value + "]");
        foreach (IComponent theComponent in m_Childs)
            theComponent.Operation();
    }

    public override void Add(IComponent theComponent)
    {
        m_Childs.Add(theComponent);
    }

    public override void Remove(IComponent theComponent)
    {
        m_Childs.Remove(theComponent);
    }

    public override IComponent GetChild(int Index)
    {
        return m_Childs[Index];
    }
}

public class Leaf : IComponent
{
    public Leaf(string value)
    {
        m_Value = value;
    }

    public override void Operation()
    {
        System.Console.WriteLine("Leaf [" + m_Value + "] deal Operation()");
    }
}