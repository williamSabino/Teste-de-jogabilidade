using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectsAnimaisVertical;
    private int animalIndex;
    private float rangeX = 20f;
    private float rangeZ = 20f;
    private float timeSpawn = 1.5f;
    private float delaySpawn = 2f;
    // Start is called before the first frame update
    void Start()
    {
        //Função para spawnar animais em um determinado tempo
        InvokeRepeating("SpawnAnimalsVertical", delaySpawn, timeSpawn);
    }

    // Update is called once per frame
    void Update()
    {
    }

    //fun~ção para randomizar tanto o tipo do animal quanto o local onde ele vai spawnar 
    void SpawnAnimalsVertical()
    {
        animalIndex = Random.Range(0, objectsAnimaisVertical.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-rangeX, rangeX), 0, rangeZ);
        Instantiate(objectsAnimaisVertical[animalIndex], spawnPos, objectsAnimaisVertical[animalIndex].transform.rotation);
    }

    
}
