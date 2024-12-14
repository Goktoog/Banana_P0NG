using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class balls : MonoBehaviour
{
    // Start is called before the first frame update
    public float initialSpeed = 10;
    [SerializeField] private float speedIncrease = 0.25f;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    private int hitCounter;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("StartBall",2f);
       // startPosition = transform.position;
       // Launch();
    }

   /* public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }*/

    
   /* private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(initialSpeed * x, initialSpeed * y);
    }*/
   private void StartBall()
   {
       rb.velocity = new Vector2(-1,0) * (initialSpeed + speedIncrease * hitCounter);
   }
   
    private void FixedUpdate()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, initialSpeed + (speedIncrease * hitCounter));
    }

    private void PlayerBounce(Transform myObject)
    {
        hitCounter++;

        Vector2 ballPos = transform.position;
        Vector2 playerPos = myObject.position;

        float xDirection, yDirection;
        if (transform.position.x > 0)
        {
            xDirection = -1;
        }
        else
        {
            xDirection = 1;
        }

       /* yDirection = (ballPos.y - playerPos.y) / myObject.GetComponent<Collider2D>().bounds.size.y;
        if (yDirection == 0)
        {
            yDirection = 0.25f;
        }

        rb.velocity = new Vector2(xDirection, yDirection) * (initialSpeed + (speedIncrease * hitCounter));*/
    }
    

    private void ResetBall()
    {
        rb.velocity = new Vector2(0,0);
        transform.position = new Vector2(0,0);
        hitCounter = 0;
        Invoke("StartBall",2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Untagged"))
        {
            ResetBall();
        }
    }
}
