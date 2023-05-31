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
    private void Start()
    {
        // Hide the map image initially
        mapImage.SetActive(false);
    }

    public void OpenMap()
    {
        // Show the map image when the button is clicked
        mapImage.SetActive(true);
        openBtn.SetActive(false);
        closeBtn.SetActive(true);
    }
    // Start is called before the first frame update
    public void CloseMap()
    {
        mapImage.SetActive(false);
        openBtn.SetActive(true);
        closeBtn.SetActive(false);
    }
    public void switchCam()
    {
        if (mainCam.activeSelf)
        {
            ARCam.SetActive(true);
            mainCam.SetActive(false);
            ///////////////////// check activeSelf => activeInHierarchy
        }
        else
        {
            mainCam.SetActive(true);
            ARCam.SetActive(false);
        }

    }
}
