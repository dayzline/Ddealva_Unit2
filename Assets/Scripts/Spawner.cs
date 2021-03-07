using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xrange = 20f;

    private void Start()
    {
        InvokeRepeating("BeginSpawining", 3.0f, 1.5f);
    }
    void Update()
    {

    }

    void BeginSpawining()
    {   
        float randXPos = Random.Range(-xrange, xrange);
        int animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 randXPlacement = new Vector3(randXPos, 0, 30);
        Instantiate(animalPrefabs[animalPrefabIndex], randXPlacement, animalPrefabs[animalPrefabIndex].transform.rotation);
    }

}
