using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManagerScript : MonoBehaviour
{
    public GameObject home;
    public GameObject tutorial;
    public GameObject tentang;

    void Start()
    {
        home.SetActive(true);
        tutorial.SetActive(false);
        tentang.SetActive(false);
    }

    public void homeClicked()
    {
        home.SetActive(true);
        tutorial.SetActive(false);
        tentang.SetActive(false);
    }

    public void tutorialClicked()
    {
        home.SetActive(false);
        tutorial.SetActive(true);
        tentang.SetActive(false);
    }

    public void tentangClicked()
    {
        home.SetActive(false);
        tutorial.SetActive(false);
        tentang.SetActive(true);
    }

    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void exitClicked()
    {
        Application.Quit();
    }
}
