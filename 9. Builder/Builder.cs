using System.Collections.Generic;

public class Director
{
    private Product m_Product;

    public Director() { }

    public void Constrcut(Builder theBuilder)
    {
        m_Product = new Product();
        theBuilder.BuildPart1(m_Product);
        theBuilder.BuildPart2(m_Product);
    }

    public Product GetResult()
    {
        return m_Product;
    }
}

public abstract class Builder
{
    public abstract void BuildPart1(Product theProduct);
    public abstract void BuildPart2(Product theProduct);
}

public class ConcreteBuilderA : Builder
{
    public override void BuildPart1(Product theProduct)
    {
        theProduct.AddPart("ConcreteBuilderA_Part1");
    }

    public override void BuildPart2(Product theProduct)
    {
        theProduct.AddPart("ConcreteBuilderA_Part2");
    }
}

public class ConcreteBuilderB : Builder
{
    public override void BuildPart1(Product theProduct)
    {
        theProduct.AddPart("ConcreteBuilderB_Part1");
    }

    public override void BuildPart2(Product theProduct)
    {
        theProduct.AddPart("ConcreteBuilderB_Part2");
    }
}

public class Product
{
    private List<string> m_Part = new List<string>();
    
    public Product()
    {

    }

    public void AddPart(string Part)
    {
        m_Part.Add(Part);
    }

    public void ShowProduct()
    {
        foreach (string part in m_Part)
            System.Console.WriteLine(part);
    }
}