using System;

public class ConcreteClassA : AbstractClass
{
	protected override void PrimitiveOperation1()
    {
        Console.WriteLine("ConcreteClassA.PrimitiveOprtation1");
    }

    protected override void PrimitiveOperation2()
    {
        Console.WriteLine("ConcreteClassA.PrimitiveOprtation2");
    }
}


public class ConcreteClassB : AbstractClass
{
    protected override void PrimitiveOperation1()
    {
        Console.WriteLine("ConcreteClassB.PrimitiveOprtation1");
    }

    protected override void PrimitiveOperation2()
    {
        Console.WriteLine("ConcreteClassB.PrimitiveOprtation2");
    }
}
