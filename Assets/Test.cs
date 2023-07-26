using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
   
    public GameObject[] gameObjects; // Array of GameObjects

    private void Start()
    {
        if (gameObjects.Length < 2)
        {
            Debug.LogWarning("At least two GameObjects are required to calculate distance.");
            return;
        }

        // Variables to store the positions of the elements with the highest distance
        Vector3 positionA = Vector3.zero;
        Vector3 positionB = Vector3.zero;
        float highestDistance = 0f;

        // Calculate distance between each pair of elements in the array
        for (int i = 0; i < gameObjects.Length - 1; i++)
        {
            for (int j = i + 1; j < gameObjects.Length; j++)
            {
                float distance = Vector3.Distance(gameObjects[i].transform.position, gameObjects[j].transform.position);

                // Check if the current distance is greater than the highestDistance
                if (distance > highestDistance)
                {
                    highestDistance = distance;
                    positionA = gameObjects[i].transform.position;
                    positionB = gameObjects[j].transform.position;
                }
            }
        }

        // Spawn an object at the position between the two elements with the highest distance
        Vector3 spawnPosition = (positionA + positionB) /2f;
        SpawnYourObjectAtPosition(spawnPosition);
    }

    private void SpawnYourObjectAtPosition(Vector3 position)
    {
        // Replace the code below with your own object spawning logic
        GameObject spawnedObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
        spawnedObject.transform.position = position;
    }
}


