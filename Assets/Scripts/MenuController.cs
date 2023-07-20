using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{ 
    public void MenuCtrl()
    {
        SceneManager.LoadSceneAsync("2D2");
    }

    public void MenuCtrl2()
    {
        SceneManager.LoadSceneAsync("2D3");
    }

    public void SceneReset()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        Debug.Log("1111");
    }
    public void SceneReset2() 
    {
        SceneManager.LoadSceneAsync("2DUI");
        Debug.Log("2222");
    }
}
