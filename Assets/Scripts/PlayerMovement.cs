using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;






    // Start is called before the first frame update
    void Start()
    {
    }



    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        float xMovement = xMove * speed * Time.deltaTime;
        float yMovement = yMove * speed * Time.deltaTime;

        //transform.position = new Vector3(transform.position.x + xMovement , 0, 0);
        transform.Translate(xMovement, yMovement, 0);

        if (GetComponent<Rigidbody2D>().gravityScale > 0 && transform.position.y < -10)
        {
            
            GetComponent<Rigidbody2D>().gravityScale = 0;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().angularVelocity = 0;
            transform.position = new Vector2 (0,0);
            transform.eulerAngles = new Vector2(0, 0);

        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        GetComponent<Rigidbody2D>().gravityScale = 2;
    }





}
