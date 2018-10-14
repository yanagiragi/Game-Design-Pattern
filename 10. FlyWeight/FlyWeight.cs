using System;

public abstract class FlyWeight
{
    protected string m_Content;

    public FlyWeight() { }

    public FlyWeight(string Content)
    {
        m_Content = Content;
    }

    public string GetContent()
    {
        return m_Content;
    }

    public abstract void Operator();
}

public class ConcreteFlyWeight : FlyWeight
{
    public ConcreteFlyWeight(string Content) : base(Content)
    {

    }

    public override void Operator()
    {
        System.Console.WriteLine("ConcreteFlyWeight.Content [" + m_Content + "]");
    }
}

public class UnsharedConcreteFlyWeight : FlyWeight
{
    FlyWeight m_FlyWeight = null;

    string m_UnsharedContent;

    public UnsharedConcreteFlyWeight(string Content)
    {
        m_UnsharedContent = Content;
    }

    public void SetFlyWeight(FlyWeight theFlyWeight)
    {
        m_FlyWeight = theFlyWeight;
    }

    public override void Operator()
    {
        string msg = String.Format("UnsharedConcreteFlyWeight.Content[{0}]", m_UnsharedContent);

        if (m_FlyWeight != null)
            msg += "include: " + m_FlyWeight.GetContent();

        System.Console.WriteLine(msg);
    }
}

public class FlyWeightFactor
{
    System.Collections.Generic.Dictionary<string, FlyWeight> m_FlyWeights = new System.Collections.Generic.Dictionary<string, FlyWeight>();

    public FlyWeight GetFlyWeight(string key, string content)
    {
        if (m_FlyWeights.ContainsKey(key))
            return m_FlyWeights[key];

        ConcreteFlyWeight theFlyWeight = new ConcreteFlyWeight(content);

        m_FlyWeights[key] = theFlyWeight;

        System.Console.WriteLine("New ConcreteFlyWeight key[" + key + "] Content[" + content + "]");

        return theFlyWeight;
    }

    public UnsharedConcreteFlyWeight GetUnsharedFlyWeight(string content)
    {
        return new UnsharedConcreteFlyWeight(content);
    }
     
    public UnsharedConcreteFlyWeight GetUnsharedFlyWeight(string key, string SharedContent, string UnSharedContent)
    {
        FlyWeight SharedFlyWeight = GetFlyWeight(key, SharedContent);

        UnsharedConcreteFlyWeight theFlyWeight = new UnsharedConcreteFlyWeight(UnSharedContent);

        theFlyWeight.SetFlyWeight(SharedFlyWeight);

        return theFlyWeight;
    }
}