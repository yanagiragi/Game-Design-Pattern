using System;

public class Receiver1
{
    public Receiver1() { }
    public void Action(string Command)
    {
        System.Console.WriteLine("Reciever1.Action:Command[" + Command + "]");
    }
}

public class Receiver2
{
    public Receiver2() { }
    public void Action(int Param)
    {
        System.Console.WriteLine("Reciever2.Action:Command[" + Param.ToString() + "]");
    }
}

public abstract class Command
{
    public abstract void Execute();
}

public class ConcreteCommand1: Command
{
    Receiver1 m_Receiver = null;
    string m_Command = null;

    public ConcreteCommand1(Receiver1 Receiver, string Command)
    {
        m_Command = Command;
        m_Receiver = Receiver;
    }

    public override void Execute()
    {
        m_Receiver.Action(m_Command);
    }
}

public class ConcreteCommand2 : Command
{
    Receiver2 m_Receiver = null;
    int m_Param = 0;

    public ConcreteCommand2(Receiver2 Receiver, int Param)
    {
        m_Param = Param;
        m_Receiver = Receiver;
    }

    public override void Execute()
    {
        m_Receiver.Action(m_Param);
    }
}

public class Invoker
{
    System.Collections.Generic.List<Command> m_Commands = new System.Collections.Generic.List<Command>();

    public void AddCommand(Command theCommand)
    {
        m_Commands.Add(theCommand);
    }

    public void ExecuteCommand()
    {
        foreach(Command theCommand in m_Commands)
        {
            theCommand.Execute();
        }

        m_Commands.Clear();
    }
}