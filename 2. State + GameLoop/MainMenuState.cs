public class MainMenuState : ISceneState
{
	public MainMenuState(SceneStateContoller Controller):base(Controller){
		this.StateName = "MainMenuState";
	}

	public override void StateBegin(){
		Button btn = UITool.GetUIComponent<Button>("StartGameButton");
		if(btn != null)
			btn.onClick.AddListener(() => OnStartGameBtnClick(btn));
	}

	private void OnStartGameBtnClick(Button btn){
		m_Controller.SetState(new BattleState(m_Controller),"BattleScene");
	}
}