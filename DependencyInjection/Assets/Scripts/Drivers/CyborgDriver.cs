using UnityEngine;
public class CyborgDriver : IDriver
{
    private Bike m_Bike;
    private float curTurnDur = 0.0f;
    private float curTurnStartTime = 0.0f;
    private int curDir = 0;
    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("This bike will be controlled by a Cyborg");
    }
    public void Steer()
    {
        //if input exist us that otherwise use AI
        if (Input.GetKey(KeyCode.A))
            m_Bike.Turn(-1);
        //turn right
        else if (Input.GetKey(KeyCode.D))
            m_Bike.Turn(1);
        else
        {
            //if the duration of current turn has passed create new AI direction command
            if (curTurnDur + curTurnStartTime <= Time.timeSinceLevelLoad)
            {
                curDir = Random.Range(-1, 2);
                curTurnDur = Random.Range(0.5f, 5.0f);
                curTurnStartTime = Time.timeSinceLevelLoad;
            }
            m_Bike.Turn(curDir);
        }
    }
}