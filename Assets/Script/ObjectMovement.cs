using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement: MonoBehaviour
{
    Quaternion targetAngle_0 = Quaternion.Euler(0, 0, 0);
    Quaternion targetAngle_90 = Quaternion.Euler(0, 90, 0);
    public Quaternion currentAngle;
    // Start is called before the first frame update
    void Start()
    {
        currentAngle = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.rotation = Quaternion.Slerp(this.transform.rotation, currentAngle, 0.2f);   
    }

    public void RotateRight()
    {
        transform.Rotate(0, 90, 0);
        //currentAngle = Quaternion.Euler(currentAngle.x,90, currentAngle.z);
    }
    public void RotateLeft()
    {
        transform.Rotate(0, -90, 0);
    }
    public void RotateUp()
    {
        transform.Rotate(-90, 0, 0);
    }
    public void RotateDown()
    {
        transform.Rotate(90, 0, 0);
    }
}
