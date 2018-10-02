public class StartState : ISceneState
{
	public StartState(SceneStateContoller Controller):base(Controller){
		this.StateName = "StartState";
	}

	public override void StateBegin(){
		// loading essential infos...
	}
	public override void StateUpdate(){
		m_Controller.SetState(new MainMenuState(m_Controller),"MainMenuScene");
	}
}