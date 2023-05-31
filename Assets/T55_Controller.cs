using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T55_Controller : MonoBehaviour
{
    public float speed = 3;
    public Vector3 target =new Vector3(0,0,1200);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed*Time.deltaTime);
    }
}
