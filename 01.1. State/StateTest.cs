using UnityEngine;

public class StateTest : MonoBehaviour
{
	void Start(){
		UnitTest ();
	}
	void UnitTest(){
		Context theContext = new Context();
		theContext.SetState(new ConcreteStateA(theContext));

		theContext.Request(5);
		theContext.Request(15);
		theContext.Request(25);
		theContext.Request(35);
	}
}