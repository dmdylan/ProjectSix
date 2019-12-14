using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement(){
        float forwardMovement;
        float sideMovement;

        forwardMovement = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
        sideMovement = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;

        transform.Translate(sideMovement, 0, forwardMovement);
    }
}
