using UnityEngine;
using System.Collections;

public class ZlatanController : MonoBehaviour 
{

    float speed = 20.0f;

    
    // Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Rotate(Vector3.back, Time.deltaTime * speed);

        if(Input.GetAxis("Horizontal") != 0)
            transform.position = new Vector3((transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime), transform.position.y, transform.position.z);        
	}

    void FixedUpdate ()
    {
       
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
            other.gameObject.rigidbody2D.AddForce(new Vector2(250, 250));
    }
}




/*if (Input.GetKeyDown(KeyCode.LeftArrow))
{
    //transform.rigidbody2D.AddForce(new Vector2(-10, 0));
    //transform.position = transform.position + new Vector3(-10, 0 , 0);
    rigidbody2D.velocity = new Vector2(-20, 0);
}
        
if (Input.GetKeyDown(KeyCode.RightArrow))
{
    //transform.rigidbody2D.AddForce(new Vector2(10, 0));
    //transform.position = transform.position + new Vector3(10, 0, 0);
    rigidbody2D.velocity = new Vector2(20, 0);
}*/

//if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
//    rigidbody2D.velocity = new Vector2(0, 0);