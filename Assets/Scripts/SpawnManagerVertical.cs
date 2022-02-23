using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerVertical : MonoBehaviour
{
    public GameObject[] objectsAnimalsLeft;
    public GameObject[] objectsAnimalsRight;
    private float delayTime = 2f;
    private float spawnTime = 2f;
    private int indexAnimals;
    private float rangeXLeft = -39f;
    private float rangeXRight = 38f;
    private float rangeZUp = 14f;
    private float rangeZBottom = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimalsVerticalLeft", delayTime, spawnTime);
        InvokeRepeating("SpawnAnimalsVerticalRight", delayTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnAnimalsVerticalLeft()
    {
        indexAnimals = Random.Range(0, objectsAnimalsLeft.Length);
        Vector3 spawnPos = new Vector3(rangeXLeft, 0, Random.Range(rangeZBottom, rangeZUp));
        Instantiate(objectsAnimalsLeft[indexAnimals], spawnPos, objectsAnimalsLeft[indexAnimals].transform.rotation);
    }
    void SpawnAnimalsVerticalRight()
    {
        indexAnimals = Random.Range(0, objectsAnimalsRight.Length);
        Vector3 spawnPos = new Vector3(rangeXRight, 0, Random.Range(rangeZBottom, rangeZUp));
        Instantiate(objectsAnimalsRight[indexAnimals], spawnPos, objectsAnimalsRight[indexAnimals].transform.rotation);

    }
}
