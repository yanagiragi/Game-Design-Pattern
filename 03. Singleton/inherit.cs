public abstract class Abs_GameSystem
{
	protected GameSystem m_instance = null;

	public Abs_GameSystem(GameSystem g){
		m_instance = g;
	}

	public void doSomeThing()
	{
		// do something
	}
}

public class GameSystem
{
	private string name = null;
	
	public void init(){
		name = new string("Hello World");
	}

	public void update(){
		// do something
	}
}

public class CarSystem : Abs_GameSystem
{
	public CarSystem(GameSystem g) : Base(g)
	{
		g.init(); // init something
	}

	public void update(){
		m_instance.update();
		g.doSomeThing();
	}
}
