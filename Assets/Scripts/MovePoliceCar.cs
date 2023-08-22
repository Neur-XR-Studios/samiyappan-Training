using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePoliceCar : MonoBehaviour
{

    public static MovePoliceCar instance;

    public float speed;
    public GameObject carfind;
    public GameObject explosionPrefab; // Assign the explosion prefab in the Inspector

    private bool exploded = false; // To track if the explosion has happened

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        carfind = GameObject.Find("PolicePoint");
        transform.position = Vector3.MoveTowards(transform.position, carfind.transform.position, speed * Time.deltaTime);
        transform.LookAt(carfind.transform.position);

        if (!exploded && Vector3.Distance(transform.position, carfind.transform.position) < 0.1f)
        {
            ExplodeAndLoadScene();
        }
    }

    private void ExplodeAndLoadScene()
    {
        exploded = true;
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
       
        SpawnPolice.instance.ButtonDisable();
        //SceneManager.LoadScene("CarUber");
    }
    

}
