using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public GameObject openSceneBtn;
    public GameObject openDesBtn;
    public GameObject OpenMapBtn;
    public GameObject backBtn;

    public GameObject mapImage;
    public GameObject panel;

    public void btnPressed(bool flag)
    {
        openSceneBtn.SetActive(flag);
        openDesBtn.SetActive(flag);
        OpenMapBtn.SetActive(flag);
    }

    public void openDes()
    {
        panel.SetActive(true);
        backBtn.SetActive(true);
        btnPressed(false);
        
    }

    public void  backPressed()
    {
        panel.SetActive(false);
        btnPressed(true);
        backBtn.SetActive(false);
        mapImage.SetActive(false);
        //image/////////////////////////////////////

    }


    public void openMap()
    {
        mapImage.SetActive(true);
        backBtn.SetActive(true);
        btnPressed(false);
    }

    public void openScene()
    {
        SceneManager.LoadScene(1);
    }
    /*
     * 
    public void ppp()
    {
        Debug.Log("aaaaa");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
