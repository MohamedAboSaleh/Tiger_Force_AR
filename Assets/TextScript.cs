using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript : MonoBehaviour
{
    public GameObject ThreeTanksText;
    public GameObject FourTanksText;
    public GameObject FightText;
    public GameObject canvas;
    public GameObject Tank;
    // Start is called before the first frame update
    void Start()
    {
        ThreeTanksText.SetActive(true);
        FourTanksText.SetActive(false);
        FightText.SetActive(false);
        canvas.SetActive(false);
        Invoke("fourText", 7.0f);
        Invoke("fightText", 13.0f);
        Invoke("canv", 20.0f);
    }
    public void fourText()
    {
        ThreeTanksText.SetActive(false);
        FourTanksText.SetActive(true);
    }
    public void fightText()
    {
        FourTanksText.SetActive(false);
        FightText.SetActive(true);
    }

    public void canv()
    {
        FightText.SetActive(false);
        canvas.SetActive(true);
        Tank.SetActive(true);
    }
}
