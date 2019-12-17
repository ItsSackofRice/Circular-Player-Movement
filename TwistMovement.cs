using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwistMovement : MonoBehaviour
{
    public int speed = 1;
    public float max = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

       transform.parent.Rotate(0, speed , 0);

       float rotate = transform.parent.rotation.eulerAngles.y;

        float x = transform.parent.position.x;
        float z = transform.parent.position.z;
        float y = transform.parent.position.y;

        transform.parent.position = new Vector3(x, y, z);
        //Debug.Log(transform.parent.rotation.eulerAngles.y);
      
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

      /* if(rotate > 270) //Q4
        {
            transform.parent.position = new Vector3(max + rotate / -390, y, z);
        }
       else if(rotate > 180) //Q3
        {
            transform.parent.position = new Vector3(max + rotate / -90, y, z);
        }
       else if(rotate > 90 ) //Q2
        {
            transform.parent.position = new Vector3(max - rotate / 90, y, z);
        }
        else //Q1
        {
            transform.parent.position = new Vector3(max - rotate/ 90, y, z);
        }
        */
    }
}
