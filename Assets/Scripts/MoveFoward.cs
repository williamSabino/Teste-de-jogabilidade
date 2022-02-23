using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //função usada para mostrar a direção que o objeto ira ser lançado e a velocide
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);   
    }
}
