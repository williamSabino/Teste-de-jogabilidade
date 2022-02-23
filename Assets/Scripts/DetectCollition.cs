using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollition : MonoBehaviour
{
    private int contador=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //essa função remove objetos que se coliden atraves dos triggers ativados no componemte box collider
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
