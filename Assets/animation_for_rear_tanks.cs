using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_for_rear_tanks : MonoBehaviour
{
    public Vector3 target1 = new Vector3(-111, (float)164, 0);
    public Vector3 target2 = new Vector3(-111, (float)164, 0);
    public Vector3 starting_point;
    public float speed = 200;
    private bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*
* funaction name:Update
* input:none
* output:void
* functionality: this function moves the object to target1 and after that from target1 to target2 and finally returns to starting_point
*/
    void Update()
    {
        if (flag)
        {
            transform.position = Vector3.MoveTowards(transform.position, target1, speed * Time.deltaTime);
            if (transform.position == target1)
            {
                flag = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, target2, speed * Time.deltaTime);
            if (transform.position == target2)
            {
                transform.position = starting_point;
                flag = true;
            }
        }
    }
}

