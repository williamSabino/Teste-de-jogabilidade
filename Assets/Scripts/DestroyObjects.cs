using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    private float topbound = 30f;
    private float bottonBound = -20f;
    private float rightAndLeftBound = 39f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //usado para destruir os objetos quando saem dos limites de tela
        if (transform.position.z > topbound || transform.position.z < bottonBound || transform.position.x > rightAndLeftBound || transform.position.x < -rightAndLeftBound)
        {
            Destroy(gameObject);
        } 
     if (transform.position.z < bottonBound)
        {
            Debug.LogError("Game over");
        }
    }
}
