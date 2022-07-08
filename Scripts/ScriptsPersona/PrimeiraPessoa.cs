using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeiraPessoa : MonoBehaviour
{
    public Transform cam; 
    public float vertical;
    public float horizontal; 
    private float verticalMin = -180;
    private float verticalMax = 180; 
    public float ajusteFino;

    public static float rotPlayX;
    public static float rotPlayZ;

    void LateUpdate()
    {
        transform.position = cam.transform.position;
    }

   
    void Update()
    {
        float rotY = vertical += Input.GetAxis("Mouse Y");
        float rotX = horizontal += Input.GetAxis("Mouse X");

        rotY = Mathf.Clamp(rotY, verticalMin, verticalMax);
        rotX = Mathf.Clamp(rotX, verticalMin, verticalMax);


        rotPlayX = rotX;
        rotPlayZ = rotY;
        
        
        transform.localEulerAngles = new Vector3(-rotY * ajusteFino, transform.eulerAngles.y, 0);
        transform.localEulerAngles = new Vector3(transform.eulerAngles.x , rotX * ajusteFino, 0);

        
    }
}
