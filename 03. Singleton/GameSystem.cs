public class GameSystem
{
	private GameSystem m_instance = null;

	public GameSystem Instance{
		get{
			if(m_instance == null){
				m_instance = new GameSystem();
			}
			return m_instance;
		}
	}

	public GameSystem(){
		// init
	}
}