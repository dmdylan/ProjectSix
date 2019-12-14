using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookInfo : MonoBehaviour
{
    [SerializeField]private float raycastDistance = 2f;
    Camera mainCamera;

    private void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        GetRayCastInfo();
    }

    private void GetRayCastInfo()
    {
        RaycastHit hit;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition) ;
        Vector3 lookPoint = ray.GetPoint(raycastDistance);

        Debug.DrawLine(ray.origin, lookPoint, Color.black);

        
        if(Physics.Raycast(ray, out hit, raycastDistance))
        {
            print(hit.collider.name);
        }
    }
        

}
