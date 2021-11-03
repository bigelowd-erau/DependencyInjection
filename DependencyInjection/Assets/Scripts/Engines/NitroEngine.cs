using UnityEngine;
public class NitroEngine : IEngine
{
    private const float thrust = 25.0f;
    public bool isOn = false;

    public void StartEngine()
    {
        OpenNitroValve();
        Debug.Log("Engine started");
        isOn = true;
    }
    public float GetThrust()
    {
        return thrust;
    }
    public bool IsOn()
    {
        return isOn;
    }
    private void OpenNitroValve()
    {
        Debug.Log("The nitro valve is open");
    }
}