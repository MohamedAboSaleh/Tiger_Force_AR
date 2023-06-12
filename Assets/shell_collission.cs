using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shell_collission : MonoBehaviour
{
    public float rad = 5;
    public GameObject explosionEffect;
    public float force = 700;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /* funaction name:OnCollisionEnter
 * input:none
 * output:void
 * functionality: this function is called when a collision is detected and the collision involves object of tag equals to Sye_Tank 
 * an explosion effect will be created
 */
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Sye_Tank")
        {
            GameObject exp=Instantiate(explosionEffect, transform.position, transform.rotation);

            Collider[] colliders= Physics.OverlapSphere(transform.position, rad);
            foreach(Collider obj in colliders)
            {
                Rigidbody rb = obj.GetComponent<Rigidbody>();
                if (rb!=null)
                    rb.AddExplosionForce(force, transform.position, rad);
                //rb.AddForce(transform.forward * 500);

            }
            Destroy(exp, 2);

            Destroy(gameObject,1);
        }
        else
            Destroy(gameObject, 1);

    }
}
