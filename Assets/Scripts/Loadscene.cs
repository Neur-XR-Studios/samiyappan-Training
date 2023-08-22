using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene : MonoBehaviour
{


    public Material materialToChange;   
    public Color oldColor = Color.green;
    public Color oldColor2 = Color.blue;
    public Color oldColor3 = Color.yellow;

    public static Loadscene instance;
    public void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void Level()
    {
        SceneManager.LoadScene("CarUber");
    }

    public void Home()
    {
        SceneManager.LoadScene("Uber");
        CoinCollections.instance.ResetScoreToPrevious();
    }
    public void LV1()
    {
        SceneManager.LoadScene("CarUber");
        CoinCollections.instance.ResetScoreToPrevious();
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
        CoinCollections.instance.ResetScoreToPrevious();
    }
   
    public void Changegreen()
    {
        if (materialToChange != null)
        {
            materialToChange.color = oldColor;
        }
    }
    public void ChangeBlue()
    {
        if (materialToChange != null)
        {
            materialToChange.color = oldColor2;
        }
    }
    public void ChangeYellow()
    {
        if (materialToChange != null)
        {
            materialToChange.color = oldColor3;
        }
    }

}
