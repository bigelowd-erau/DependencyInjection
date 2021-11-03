using UnityEngine;
public class Bike : MonoBehaviour
{
    private IEngine m_Engine;
    private IDriver m_Driver;
    public float turningForce;
    public Rigidbody rb;
    // Setter injection
    public void SetEngine(IEngine engine)
    {
        m_Engine = engine;
        turningForce = 1/m_Engine.GetThrust() * 1000;
        Debug.Log(m_Engine.ToString());
    }
    // Setter injection
    public void SetDriver(IDriver driver)
    {
        m_Driver = driver;
        Debug.Log(m_Driver.ToString());
    }
    public void StartEngine()
    {
        // Starting the engine
        m_Engine.StartEngine();
        // Giving control of the bike to a driver (AI or player)
        m_Driver.Control(this);
    }
    public void Drive()
    {
        m_Driver.Steer();
        if (m_Engine.IsOn())
            MoveForwards();
    }

    private void MoveForwards()
    {
        //sets the velocity angle to match the rotation, and power is determined by engine
        rb.velocity=new Vector3(Mathf.Sin(Mathf.Deg2Rad * transform.rotation.eulerAngles.y) * m_Engine.GetThrust(), 0.0f, Mathf.Cos(Mathf.Deg2Rad * transform.rotation.eulerAngles.y) * m_Engine.GetThrust());
    }
    public void Turn(int dir)//1 == right //-1 == left
    {
        //caluates a new angle based on turning force
        transform.rotation = Quaternion.Euler(90f, transform.rotation.eulerAngles.y + dir * turningForce * Time.deltaTime, 0f);
    }
    public bool CanDrive()
    {
        //if bike has an engine, driver, and is on, it can drive
        return m_Engine != null && m_Driver != null && m_Engine.IsOn();
    }
}