public static class globalController
{
	public controller Instance;
	
	public globalController(){
		Instance = new controller();
	}
}

public class controller
{
	private CarSystem m_carSystem = null;	
	private ShipSystem m_shipSystem = null;	

	public controller(){
		m_carSystem = new CarSystem();
		m_shipSystem = new ShipSystem();
	}
	
	public void update(){
		m_carSystem.Update();
		m_shipSystem.Update();
	}
}