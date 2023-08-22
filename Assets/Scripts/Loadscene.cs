using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene : MonoBehaviour
{

   

    public void Level()
    {
        SceneManager.LoadScene("CarUber");
    }

    public void Home()
    {
        SceneManager.LoadScene("Uber");
    }
    public void LV1()
    {
        SceneManager.LoadScene("CarUber");
    }
    public void LV2()
    {
        SceneManager.LoadScene("green");

    }
    public void LV3()
    {
        SceneManager.LoadScene("yellow");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
