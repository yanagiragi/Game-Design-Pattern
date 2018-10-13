public abstract class Creator
{
    public abstract Product FactoryMethod();
}

public abstract class Product
{

}

public class ConcreteProductA : Product
{
    public ConcreteProductA()
    {
        System.Console.WriteLine("Create Product A");
    }
}

public class ConcreteProductB : Product
{
    public ConcreteProductB()
    {
        System.Console.WriteLine("Create Product B");
    }
}

public class ConcreteCreatorProductA : Creator
{
    public ConcreteCreatorProductA()
    {
        System.Console.WriteLine("Create Factory: ConcreteCreatorProductA");
    }

    public override Product FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

public class ConcreteCreatorProductB : Creator
{
    public ConcreteCreatorProductB()
    {
        System.Console.WriteLine("Create Factory: ConcreteCreatorProductB");
    }

    public override Product FactoryMethod()
    {
        return new ConcreteProductB();
    }
}

// Method Type
public abstract class Creator_MethodType
{
    public abstract Product FactoryMethod(int type);
}

public class ConcreteCreator_MethodType : Creator_MethodType
{
    public ConcreteCreator_MethodType()
    {
        System.Console.WriteLine("Create Factory: ConcreteCreator_MethodType");
    }

    public override Product FactoryMethod(int type)
    {
        switch (type)
        {
            case 1: return new ConcreteProductA();
            case 2: return new ConcreteProductB();
            default:
                System.Console.WriteLine("Type[" + type + "] Cannot Found");
                break;
        }
        return null;
    }
}

// Generic Class
public class Creator_GenericClass<T> where T : Product, new()
{
    public Creator_GenericClass()
    {
        System.Console.WriteLine("Create Factory: Creator_GenericClass<" + typeof(T).ToString() + ">");
    }

    public Product FactoryMethod()
    {
        return new T();
    }
}

// Generic Method
interface Creator_GenericMethod
{
    Product FactoryMethod<T>() where T : Product, new();
}

public class ConcreteCreator_GenericMethod : Creator_GenericMethod
{
    public ConcreteCreator_GenericMethod()
    {
        System.Console.WriteLine("Create Factory: ConcreteCreator_GenericMethod");
    }

    public Product FactoryMethod<T>() where T : Product, new()
    {
        return new T();
    }
}