using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make it visable in Unity panel which is collaped in Boundary
[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayController : MonoBehaviour {
    public float speed;
    public Boundary boundary;
	public float tilt;

    void FixedUpdate()
    {
        //grabe from the input 
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertial = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertial);
        GetComponent<Rigidbody>().velocity=movement * speed;
        //GetComponent<Rigidbody>().AddForce(movement * speed);

		//area constrain
        GetComponent<Rigidbody>().position = new Vector3
        (
            //current possion should between min and max
            Mathf.Clamp(GetComponent<Rigidbody>().position.x,boundary.xMin,boundary.xMax),
            0.0f,
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
        );

		//rotation
		GetComponent<Rigidbody>().rotation =
			Quaternion.Euler( new Vector3 (0.0f,0.0f,GetComponent<Rigidbody>().velocity.x*-tilt));

    
    }
}
