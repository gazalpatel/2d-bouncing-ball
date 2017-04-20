using UnityEngine;
using System.Collections;

public class BallBehaviourScipt : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // This Function appies physic code on game object
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
       // float moveVerticle = Input.GetAxis("Verticle");

        //Vector3 movement = new Vector3(moveHorizontal, moveVerticle, 0.0f);

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        rigidbody.AddForce(movement);
        Vec;

    }
}
