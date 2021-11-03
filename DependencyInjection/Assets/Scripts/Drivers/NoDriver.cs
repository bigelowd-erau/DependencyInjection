using UnityEngine;
public class NoDriver : IDriver
{
    private Bike m_Bike;
    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("This bike will be controlled by no one");
    }
    public void Steer()
    {

    }
}