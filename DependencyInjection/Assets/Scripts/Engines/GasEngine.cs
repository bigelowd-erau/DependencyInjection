using UnityEngine;
public class GasEngine : IEngine
{
    private const float thrust = 15.0f;
    private bool isOn = false;

    public void StartEngine()
    {
        TurnOver();
        Debug.Log("Engine started");
        isOn = true;
    }
    private void TurnOver()
    {
        Debug.Log("Turning engine over");
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