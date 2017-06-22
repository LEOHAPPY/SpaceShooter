using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByContact : MonoBehaviour {
    public GameObject explosion;
    public GameObject playExplosion;
    
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        if (other.tag == "Boundary")
        {
            return; //return to it's controll as a loop
        }
        if (other.tag == "Player")
        {
            Instantiate(playExplosion, transform.position, transform.rotation);
        }
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
