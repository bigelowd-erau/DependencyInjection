using UnityEngine;
public class JetEngine : IEngine
{
    private const float thrust = 50.0f;
    private bool isOn = false;
    public void StartEngine()
    {
        ActivateJetStream();
        Debug.Log("Engine started");
        isOn = true;
    }
    private void ActivateJetStream()
    {
        Debug.Log("The jet stream is activated");
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