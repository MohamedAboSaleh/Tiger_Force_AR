using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Tank : MonoBehaviour
{
    public int total_number_of_tanks = 20;
    public int counter = 1;
    public GameObject child_object;


    /*
     * funaction name:Start
     * input:none
     * output:void
     * functionality: Start is called before the first frame update
     * and calls InstantiateObject after 5 seconds
     */

    void Start()
    {
        if(counter< total_number_of_tanks)
        {
            Invoke("InstantiateObject", 5.0f);

        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
     * funaction name:InstantiateObject
     * input:none
     * output:void
     * functionality: this function instantiate child object which is a tank
     */
    void InstantiateObject()
    {
        
        // Instantiate the object at the specified spawn point
        Vector3 pos = new Vector3(0, 40, 50000);
        Quaternion rot = Quaternion.Euler(-90, 0, 180);
        Vector3 scale = new Vector3(10, 10, 10);
        GameObject newObj = Instantiate(child_object, pos, rot);
        Create_Tank script = newObj.GetComponent<Create_Tank>();
        script.counter = counter + 1;
        Move_Tank move = newObj.GetComponent<Move_Tank>();
        move.target.z = move.target.z + 500;

    }
}
