public class Memento
{
    string m_State;

    public string GetState()
    {
        return m_State;
    }

    public void SetState(string state)
    {
        m_State = state;
    }
}
public class Originator
{
    string m_State;

    public void SetInfo(string state)
    {
        m_State = state;
    }

    public void ShowInfo()
    {
        System.Console.WriteLine("Originator State: " + m_State);
    }

    public Memento CreateMemento()
    {
        Memento newMemento = new Memento();
        newMemento.SetState(m_State);
        return newMemento;
    }

    public void SetMemento(Memento m)
    {
        m_State = m.GetState();
    }
}

public class Caretaker
{
    System.Collections.Generic.Dictionary<string, Memento> m_Mementos = new System.Collections.Generic.Dictionary<string, Memento>();

    public void AddMemento(string version, Memento theMemento)
    {
        if (m_Mementos.ContainsKey(version) == false)
            m_Mementos.Add(version, theMemento);
        else
            m_Mementos[version] = theMemento;
    }

    public Memento GetMemento(string version)
    {
        if (m_Mementos.ContainsKey(version) == false)
            return null;
        return m_Mementos[version];
    }
}