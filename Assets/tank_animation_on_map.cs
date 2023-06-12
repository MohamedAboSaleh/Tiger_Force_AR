using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_animation_on_map : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 target = new Vector3(-111, (float)164, 0);
    public Vector3 starting_point;
    public float speed = 200;
 
   
    
    void Start()
    {


    }
    /* funaction name:Update
* input:none
* output:void
* functionality: this function moves the object to target and after that from target to starting_point
*/
    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position == target)
        {
            transform.position = starting_point;
        }
           
    }

  
  
}
