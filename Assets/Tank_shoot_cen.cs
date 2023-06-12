using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_shoot_cen : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefap;
    [SerializeField]
    private GameObject bulletPoint;
    [SerializeField]
    private float bulletSpeed=600;
    public float start_shooting_time= 2.5f;
    public float delay_shooting_time= 5.0f;
    // Start is called before the first frame update

    /*
    * funaction name:Start
    * input:none
    * output:void
    * functionality: this function call the function Shoot repeatidly
    */
    void Start()
    {
        InvokeRepeating("Shoot", start_shooting_time, delay_shooting_time);
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
* funaction name:Shoot
* input:none
* output:void
* functionality: this function instantiate an object of type redkin_shell
*/
    void Shoot()
    {
        Quaternion rot = Quaternion.Euler(0, 0, -85);
        GameObject bullet=Instantiate(bulletPrefap, bulletPoint.transform.position, rot);
        bullet.GetComponent<Rigidbody>().AddForce(bulletPoint.transform.forward * bulletSpeed);

        //Destroy(bullet, 2);
    }
}
