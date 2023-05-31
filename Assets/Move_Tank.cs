using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Tank : MonoBehaviour
{
    public float speed = 200;
    public Vector3 target = new Vector3(0, (float)20.66075, 1200);

    //private bool messagePrinted = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position == target)
        {
            GetComponent<AudioSource>().Stop();
            GetComponent<Move_Tank>().enabled = false;
            
        }
            
        /*if (!messagePrinted && transform.position == target)
        {
            Debug.Log(transform.position);
            messagePrinted =true;
        }*/
            
    }
}
