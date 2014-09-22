using UnityEngine;
using System.Collections;

public class KeeperController : MonoBehaviour {

    float speed = 2.0f;
    public float xBoundry;
    
    // Use this for initialization
	void Start () 
    {
        rigidbody2D.velocity = new Vector2(speed, 0);
        //rigidbody2D.AddForce(new Vector2(speed, 0));
        //transform.position = new Vector3((transform.position.x + speed * Time.deltaTime), transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        //Debug.Log(rigidbody2D.velocity.magnitude);

        if (transform.position.x >= xBoundry)
        {
            Debug.Log("X'ten büyük");
            //transform.position = new Vector3(xBoundry, transform.position.y, transform.position.z);
            //transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
            //rigidbody2D.AddForce(new Vector2(-speed, 0));
            rigidbody2D.velocity = -(rigidbody2D.velocity);
            //Debug.Log(rigidbody2D.velocity.magnitude);
        }

        if (transform.position.x <= -xBoundry)
        {
            Debug.Log("X'ten küçük");
            //transform.position = new Vector3(-xBoundry, transform.position.y, transform.position.z);
            //transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
            //rigidbody2D.AddForce(new Vector2(speed, 0));
            rigidbody2D.velocity = -(rigidbody2D.velocity);
            //Debug.Log(rigidbody2D.velocity.magnitude);
        }
	}
}
