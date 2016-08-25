using UnityEngine;

/* Context : State Holder */
public class Context : MonoBehaviour
{
	// this variable stores current state
	State m_State = null;

	public void Request(int Value){
		m_State.Handle(Value);
	}

	public void SetState(State theState){
		Debug.Log("Context.m_State has changed to " + theState);
		m_State = theState;
	}
}

public abstract class State
{
	// declared 'protected' to allow child class modified it
	protected Context m_Context = null;
	
	// Constructor
	public State(Context theContext){
		m_Context = theContext;
	}

	// Abstract method to be implemented
	public abstract void Handle(int Value);
}

// State A
public class ConcreteStateA : State
{
	// Constructor
	public ConcreteStateA(Context theContext) : base(theContext) {}

	public override void Handle(int Value){
		Debug.Log("ConcreteStateA.Handle");
		if(Value > 10)
			m_Context.SetState(new ConcreteStateB(m_Context));
	}
}

// State B
public class ConcreteStateB : State
{
	// Constructor
	public ConcreteStateB(Context theContext) : base(theContext) {}

	public override void Handle(int Value){
		Debug.Log("ConcreteStateB.Handle");
		if(Value > 20)
			m_Context.SetState(new ConcreteStateC(m_Context));
	}
}

// State C
public class ConcreteStateC : State
{
	// Constructor
	public ConcreteStateC(Context theContext) : base(theContext) {}

	public override void Handle(int Value){
		Debug.Log("ConcreteStateC.Handle");
		if(Value > 30)
			m_Context.SetState(new ConcreteStateA(m_Context));
	}
}

/*
	Using two ways to transfrom states:
	1. Allow 'Context' to transform states
	2. Passing it to Context, soon assign it to m_State,
	   then Allow 'State' to transform

	It is said that the second way is better due to:
	1. Obviously State Object gets more clearly in what condition 
	   it should change to next state , for that we can't calm conditions 
	   and what's the state will transformed to only in 'State'.
	2. Each 'ConcreteState' are allow to have it's unique value, which
	   is reference to changing state or not, since that it is better to
	   store those values in class their belong.
	3. Since conditions and values are store in 'ConcreteState', the size of
	   'Context' can be minimized.
*/