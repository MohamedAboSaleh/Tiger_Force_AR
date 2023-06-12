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
    public GameObject play_audio;
    public GameObject mapImage;
    public GameObject panel;

    /* funaction name:btnPressed
* input:none
* output:bool flag
* functionality: this function changes the status of openSceneBtn, openDesBtn, OpenMapBtn based on the value of flag
*/
    public void btnPressed(bool flag)
    {
        openSceneBtn.SetActive(flag);
        openDesBtn.SetActive(flag);
        OpenMapBtn.SetActive(flag);
    }
    /* funaction name:openDes
* input:none
* output:void
* functionality: this function desplays the description and the audio button
*/
    public void openDes()
    {
        panel.SetActive(true);
        backBtn.SetActive(true);
        play_audio.SetActive(true);
        play_audio.GetComponent<AudioSource>().time = 0f;
        btnPressed(false);
        
    }
    /* funaction name:backPressed
* input:none
* output:void
* functionality: this function updates the main menu when the back button is pressed
*/
    public void  backPressed()
    {
        panel.SetActive(false);
        btnPressed(true);
        backBtn.SetActive(false);
        mapImage.SetActive(false);
        play_audio.SetActive(false);
      

    }

    /* funaction name:openMap
* input:none
* output:void
* functionality: this function displays the map and starts the animation
*/
    public void openMap()
    {
        mapImage.SetActive(true);
        backBtn.SetActive(true);
        btnPressed(false);
        
    }
    /* funaction name:openScene
* input:none
* output:void
* functionality: this function loads the AR secene
*/
    public void openScene()
    {
        SceneManager.LoadScene(1);
    }
    /* funaction name:play_aud
* input:none
* output:void
* functionality: this function plays the audio of the description
*/
    public void play_aud()
    {
        play_audio.GetComponent<AudioSource>().Play();
    }

}
