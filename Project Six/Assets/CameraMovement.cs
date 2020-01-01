using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        ChaseCam();
    }

    private void ChaseCam()
    {
        float bias = 0.96f;
        Vector3 moveCamTo = transform.position - transform.forward * 10.0f + Vector3.up * 5.0f;

        Camera.main.transform.position = Camera.main.transform.position * bias + moveCamTo * (1.0f-bias);

        Camera.main.transform.LookAt(transform.position + transform.forward * 30.0f);
    }
}
