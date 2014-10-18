using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour 
{
    public float minSpeed;
    public float maxSpeed;
    //private Vector2 threeDVelocity;
    //public Vector2 curSpeed;
    public AudioClip brickSound;
	// Use this for initialization
	void Start () 
    {
        
        rigidbody2D.velocity = new Vector2(Random.Range(2.0f, 4.0f), -minSpeed);
        //threeDVelocity = rigidbody2D.velocity;
        
        //rigidbody2D.AddRelativeForce(new Vector2(Random.Range(0.0f, 5.0f), -minSpeed));
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
        //rigidbody2D.velocity = minSpeed * rigidbody2D.velocity.normalized;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        /*if (other.gameObject.tag == "Player")
        {
            //rigidbody2D.AddRelativeForce(new Vector2(minSpeed, Random.Range(1, 3)));
            
            //rigidbody2D.velocity = new Vector2(Random.Range(1.0f, 2.0f) * rigidbody2D.velocity.x, minSpeed * (rigidbody2D.velocity.normalized.y));
            Debug.Log("Player collided." + rigidbody2D.velocity.x + " - " + rigidbody2D.velocity.y);
        }*/

        Debug.Log("velocity x = " + rigidbody2D.velocity.x + " *** velocity y = " + rigidbody2D.velocity.y);

        if (Mathf.Abs(rigidbody2D.velocity.x) < 1.4f || Mathf.Abs(rigidbody2D.velocity.y) < 1.8f)
        {
            Debug.Log("Hız azaldı.");

            if (other.gameObject.tag == "Player")
            {

                if(rigidbody2D.velocity.x > 0)
                    rigidbody2D.velocity = new Vector2(Random.Range(2.0f, 4.0f), minSpeed);
                else
                    rigidbody2D.velocity = new Vector2(Random.Range(-4.0f, -2.0f), minSpeed);
                
                Debug.Log("Player'da hız değiştirildi.");
            }

            if (other.gameObject.tag == "Brick")
            {

                if (rigidbody2D.velocity.x > 0)
                    rigidbody2D.velocity = new Vector2(Random.Range(2.0f, 4.0f), -minSpeed);
                else
                    rigidbody2D.velocity = new Vector2(Random.Range(-4.0f, -2.0f), -minSpeed);
                
                Debug.Log("Brick'te hız değiştirildi.");
            }
        }
        
        //if (other.gameObject.tag == "Wall" || other.gameObject.tag == "Brick")

            //rigidbody2D.velocity = new Vector2(minSpeed * (rigidbody2D.velocity.normalized.x), rigidbody2D.velocity.normalized.y);

            //rigidbody2D.AddRelativeForce(new Vector2(minSpeed, minSpeed));

        if (other.gameObject.tag == "Brick")
        {
            audio.PlayOneShot(brickSound);
            Destroy(other.gameObject);
        }
    }
}
