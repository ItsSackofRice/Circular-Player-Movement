using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwistMovement : MonoBehaviour
{
    public int speed = 1;
    public float max = 1.5f;


    // Update is called once per frame
    void Update()
    {
       // Rotation of parent gameobject
       transform.parent.Rotate(0, speed , 0);

       float rotate = transform.parent.rotation.eulerAngles.y;

        float x = transform.parent.position.x;
        float z = transform.parent.position.z;
        float y = transform.parent.position.y;

        transform.parent.position = new Vector3(x, y, z);
        
      // Detects the key pressed and changes the direction
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(speed > 0)
            {
               speed = speed * -1;
                transform.parent.Rotate(0, speed, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (speed < 0)
            {
                speed = speed * -1;
                transform.parent.Rotate(0, speed, 0);
            }
        }

    }
}
