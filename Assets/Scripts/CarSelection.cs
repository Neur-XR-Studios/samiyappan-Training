using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class CarSelection : MonoBehaviour
{
    public UnityEvent LoadEvent;

    public string SceneName;
    string Number;
    void Start()
    {
        
        Number = PlayerPrefs.GetString("Numbers");
        if (Number == "Reset")
        {
            LoadEvent.Invoke();
            PlayerPrefs.DeleteKey("Numbers");

        }

        else
        {
            //  no 
        }
    }
    public void TryAgain()
    {
        PlayerPrefs.SetString("Numbers", "Reset");

        SceneManager.LoadScene(SceneName);

    }
}
