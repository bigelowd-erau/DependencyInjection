using UnityEngine;
public class HumanDriver : IDriver
{
    private Bike m_Bike;
    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("A human (player) will control the bike");
    }

    public void Steer()
    {
        //turn left
        if (Input.GetKey(KeyCode.A))
            m_Bike.Turn(-1);
        //turn right
        else if (Input.GetKey(KeyCode.D))
            m_Bike.Turn(1);
    }
}