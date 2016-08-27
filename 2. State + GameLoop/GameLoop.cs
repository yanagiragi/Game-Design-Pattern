public class GameLoop : MonoBehaviour
{
	SceneStateController m_SceneStateController = new SceneStateController();

	void Awake(){
		GameObject.DonDestroyOnLoad(this.GameObject);
	}

	void Start(){
		m_SceneStateController.SetState(new StartState(m_SceneStateController), "");
	}

	void Update(){
		m_SceneStateController.StateUpdate();
	}
}

/*
	Note : 
		Use 'State' if States in game are few.
		It is not recommend to use it when game contains lots of state,
		though it is always better than using "switch(state_status_code)".
*/