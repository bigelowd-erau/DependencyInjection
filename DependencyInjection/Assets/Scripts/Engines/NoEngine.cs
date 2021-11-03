using UnityEngine;
public class NoEngine : IEngine
{
    private const float thrust = 2.5f;
    public bool isOn = false;
    public void StartEngine()
    {
        PushByFoot();
        Debug.Log("You hop off hold the bike");
        isOn = true;
    }
    private void PushByFoot()
    {
        Debug.Log("Pushing bike by foot");
    }
    public float GetThrust()
    {
        return thrust;
    }
    public bool IsOn()
    {
        return isOn;
    }
}