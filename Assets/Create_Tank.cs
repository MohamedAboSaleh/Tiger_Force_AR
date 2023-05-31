using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Tank : MonoBehaviour
{
    public int total_number_of_tanks = 20;
    public int counter = 1;
    public GameObject child_object;
   // public AudioClip soundClip;
   // private AudioSource audioSource;
    // Start is called before the first frame update
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
        /*
        audioSource = newObj.AddComponent<AudioSource>();

        // Set the audio clip
        audioSource.clip = soundClip;

        // Set the loop property to true to play the sound continuously
        audioSource.loop = true;
        audioSource.volume = 0.5f;

        // Play the sound
        audioSource.Play();
        //newObj.transform.localScale = scale;
        */
    }
}
