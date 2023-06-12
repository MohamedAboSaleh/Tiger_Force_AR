using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Tank : MonoBehaviour
{
    public float speed = 200;
    public Vector3 target = new Vector3(0, (float)20.66075, 1200);

    
    void Start()
    {

    }

    /* funaction name:Update
 * input:none
 * output:void
 * functionality: this function moves the tank object to the tagret point
 */
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position == target)
        {
            GetComponent<AudioSource>().Stop();
            GetComponent<Move_Tank>().enabled = false;
            
        }
            

            
    }
}
