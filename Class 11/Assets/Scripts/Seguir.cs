using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject destino;  
    public int vel = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (destino != null)
        transform.position=Vector3.MoveTowards(transform.position,destino.transform.position, vel*Time.deltaTime );
        transform.up=destino.transform.position;
    }
    // private void OnCollisionEnter(Collision collision)
    // {
    //     Debug.Log(collision.gameObject.name);
    //     if (collision.gameObject.name == "Destino")
    //     {
    //         Destroy(collision.gameObject, 2);
    //     }
    // }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name== "Destino")
        {
            Destroy(other.gameObject, 2);
        }
    }
}
