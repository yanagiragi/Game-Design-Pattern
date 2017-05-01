public class GameSystem
{

	// Client interface

	private CarSystem m_carSystem = null;	
	private ShipSystem m_shipSystem = null;	

	public GameSystem(){
		m_carSystem = new CarSystem();
		m_shipSystem = new ShipSystem();
	}

	public void Update(){
		m_carSystem.Update();
		m_shipSystem.Update();
	}
}