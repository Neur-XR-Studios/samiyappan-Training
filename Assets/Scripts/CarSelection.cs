using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class CarSelection : MonoBehaviour
{
    public UnityEvent LoadEvent;

    public string SceneName;
    string value1;
    void Start()
    {
        
        value1 = PlayerPrefs.GetString("Value");
        if (value1 == "Dup")
        {
            LoadEvent.Invoke();
            PlayerPrefs.DeleteKey("Value");

        }

        else
        {
            //
        }
    }
    public void TryAgain()
    {
        PlayerPrefs.SetString("Value", "Dup");

        SceneManager.LoadScene(SceneName);

    }
}
