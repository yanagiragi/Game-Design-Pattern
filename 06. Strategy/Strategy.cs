using System;

public abstract class Strategy
{
    public abstract void AlgorithmInterface();
}

public class ConcreteStrategyA : Strategy{
    public override void AlgorithmInterface()
    {
        Console.WriteLine("ConcreteStrategyA.AlgorithmInterface");
    }
}

public class ConcreteStrategyB : Strategy{
    public override void AlgorithmInterface()
    {
        Console.WriteLine("ConcreteStrategyB.AlgorithmInterface");
    }
}