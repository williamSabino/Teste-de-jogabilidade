using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalSpeed;
    public float verticalSpeed;
    private float speed = 30f;
    private float rangePlayer = 20f;
    public float rangeVerticalTop = 15.0f;
    public float rangeVerticalBottom = 1.0f;
    public GameObject[] prefabsFood;
    private int indexFood;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > rangeVerticalTop)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, rangeVerticalTop);
        }
        if (transform.position.z < rangeVerticalBottom)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, rangeVerticalBottom);
        }

        //if sendo usado para limitar movimento do player na linha x para que não saia da posição da camera
        if (transform.position.x < -rangePlayer)
        {
            transform.position = new Vector3(-rangePlayer, transform.position.y, transform.position.z);
        }
        if (transform.position.x > rangePlayer)
        {
            transform.position = new Vector3(rangePlayer, transform.position.y, transform.position.z);
        }

        HorizontalSpeed = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalSpeed * Time.deltaTime * speed);
        verticalSpeed = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalSpeed * Time.deltaTime * speed);

        indexFood = Random.Range(0, prefabsFood.Length);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(prefabsFood[indexFood], transform.position, prefabsFood[indexFood].transform.rotation);
        }
    }
    //Serve para toda vez que pressionado o botão space o player lança um objeto


}
