using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewMap : MonoBehaviour
{
    public GameObject mapImage;
    public GameObject openBtn;
    public GameObject closeBtn;
    public GameObject mainCam;
    public GameObject ARCam;
    public GameObject canv_cam;
    public GameObject tank;
    public GameObject can;
    public GameObject canvas_for_map;
    public GameObject switch_cam;
    public GameObject destroyed;
    GameObject current_cam;
   

    private void Start()
    {
        mapImage.SetActive(false);
        current_cam = ARCam;
    }

    /* funaction name:OpenMap
* input:none
* output:void
* functionality: this function displays the map and starts the animation
*/
    public void OpenMap()
    {
        can.SetActive(false);
        canvas_for_map.SetActive(true);
        openBtn.SetActive(false);
        closeBtn.SetActive(true);
        canv_cam.SetActive(true);
        current_cam.SetActive(false);
        switch_cam.SetActive(false);
        tank.SetActive(false);
        

    }
    /* funaction name:CloseMap
* input:none
* output:void
* functionality: this function closes the map and returns the previous scene
*/
    public void CloseMap()
    {
        
        can.SetActive(true);
        canvas_for_map.SetActive(false);
        
        openBtn.SetActive(true);
        closeBtn.SetActive(false);
        canv_cam.SetActive(false);
        current_cam.SetActive(true);
        switch_cam.SetActive(true);
        tank.SetActive(true);
        
    }
    /* funaction name:switchCam
* input:none
* output:void
* functionality: this function switches between AR camera and main camera if the switch view button was pressed
*/
    public void switchCam()
    {
        if (mainCam.activeSelf)
        {
            current_cam = ARCam;
            ARCam.SetActive(true);
            mainCam.SetActive(false);
            destroyed.SetActive(false);
            ///////////////////// check activeSelf => activeInHierarchy
        }
        else
        {
            current_cam = mainCam;
            mainCam.SetActive(true);
            ARCam.SetActive(false);
            destroyed.SetActive(true);
        }

    }
}
