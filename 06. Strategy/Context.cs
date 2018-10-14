public class Context
{
    Strategy m_Strategy = null;

    public void SetStrategy(Strategy theStrategy)
    {
        m_Strategy = theStrategy;
    }

    public void ContextInterface()
    {
        m_Strategy.AlgorithmInterface();
    }
}