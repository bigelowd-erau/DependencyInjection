using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Bike m_bike;
    private Vector3 offset = new Vector3(0.0f, 2.72f, -5.0f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = m_bike.transform.position + offset;
    }
}
