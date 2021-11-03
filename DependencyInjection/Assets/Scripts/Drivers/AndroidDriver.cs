using UnityEngine;
public class AndroidDriver : IDriver
{
    private Bike m_Bike;
    private float curTurnDur = 0.0f;
    private float curTurnStartTime = 0.0f;
    private int curDir = 0;
    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("This bike will be controlled by an Android");
    }
    public void Steer()
    {
        //if the duration of current turn has passed create new AI direction command
        if (curTurnDur + curTurnStartTime <= Time.timeSinceLevelLoad)
        {
            //get a randon direction (-1,0,1) left, right, or straight
            curDir = Random.Range(-1, 2);
            //get a duration of the turn from .5 seconds to 5 seconds
            curTurnDur = Random.Range(0.5f, 5.0f);
            curTurnStartTime = Time.timeSinceLevelLoad;
        }
        m_Bike.Turn(curDir);
    }
}