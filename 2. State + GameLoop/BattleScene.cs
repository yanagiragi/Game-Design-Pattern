public class BattleScene : ISceneState
{
	public BattleScene(SceneStateContoller Controller):base(Controller){
		this.StateName = "BattleScene";
	}

	public override void StateBegin(){
		PBaseDefenseGame.Instance.Initial();
	}

	public override void StateBEnd(){
		PBaseDefenseGame.Instance.Release();
	}

	public override void StateUpdate(){		

		// deal with input
		InputProcess();

		// game logic
		PBaseDefenseGame.Instance.Update();

		// check if game ends
		if(PBaseDefenseGame.Instance.ThisGameIsOver())
			m_Contoller.SetState(new MainMenuState(m_Contoller), "MainMenuState");
	
	}

	private void InputProcess(){
		// deal with inputs...
	}

}