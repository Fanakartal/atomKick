using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour 
{
    public float minSpeed;
    public float maxSpeed;
    public Vector2 curSpeed;
	// Use this for initialization
	void Start () 
    {
        //rigidbody2D.velocity = new Vector2(0, minSpeed);
        rigidbody2D.AddRelativeForce(new Vector2(2, -minSpeed));
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void FixedUpdate()
    {
        //rigidbody2D.velocity = new Vector2(/*move * */ rigidbody2D.velocity.x, rigidbody2D.velocity.y);

        //curSpeed = new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y);

        //if (curSpeed > maxSpeed)
        //    rigidbody2D.velocity /= curSpeed / maxSpeed;
        //if (curSpeed < minSpeed && curSpeed > 0)
        //    rigidbody2D.velocity /= curSpeed / minSpeed;
    }

    void LateUpdate()
    {
        rigidbody2D.velocity = minSpeed * (rigidbody2D.velocity.normalized);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall" || other.gameObject.tag == "Brick")
            //rigidbody2D.velocity = minSpeed * (rigidbody2D.velocity.normalized);
            rigidbody2D.AddRelativeForce(new Vector2(minSpeed, minSpeed));

        if (other.gameObject.tag == "Brick")
            Destroy(other.gameObject);
    }
}
