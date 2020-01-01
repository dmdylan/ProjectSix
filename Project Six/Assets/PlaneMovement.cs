using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float planeSpeed = 90.0f;


    // Update is called once per frame
    void Update()
    {
        PreventPlayerFromGoingThroughTheGround();
    }

    private void FixedUpdate()
    {
        PlayerInputToMovePlane();
    }

    private void PlayerInputToMovePlane()
    {
        transform.position += transform.forward * Time.deltaTime * planeSpeed;

        planeSpeed -= transform.forward.y * Time.deltaTime * 50.0f;

        if (planeSpeed < 35)
            planeSpeed = 35;
        if (planeSpeed > 110)
            planeSpeed = 110;

        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal") * 5f);        
    }

    private void PreventPlayerFromGoingThroughTheGround()
    {
        float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight(transform.position);

        if(terrainHeightWhereWeAre > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,
                                             terrainHeightWhereWeAre,
                                             transform.position.z);
        }
    }
}
