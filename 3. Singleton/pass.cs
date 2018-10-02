public class GameSystem
{
	private ShipSystem m_shipSystem = null;
	private CarSystem m_carSystem = null;

	public void init(){

		m_shipSystem = new ShipSystem();
		m_carSystem = new CarSystem();

		m_shipSystem.setSystem(m_carSystem);
	}
}

public class CarSystem
{
	private ShipSystem m_shipSystem = null;
	
	public CarSystem(GameSystem g){
		
	}

}

public class ShipSystem
{
	public void setSystem(CarSystem g){
		// set system
	}
}