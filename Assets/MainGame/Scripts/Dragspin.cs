using UnityEngine;
 
public class Dragspin : MonoBehaviour {
    //float rotationSpeed = 0.2f;
    float rotSpeed = 20;


    void OnMouseDrag()
    {
        //float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        //float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
        //transform.RotateAround(Vector3.down, XaxisRotation);
        //transform.RotateAround(Vector3.right, YaxisRotation);

        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;
        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.right, rotY);
    }
}
