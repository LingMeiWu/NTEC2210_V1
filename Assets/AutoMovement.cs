using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    public float speed = 3.0f;




    // Update is called once per frame
    void Update()
    {
        // How to make the "car" move to the right by itself
        // Hint: In Unity you can get Vector (direction) shorthands like this:
        // Vector3.up (etc)

       // private Vector3 x = Vector3.right;

        var x = Vector3.right;
      
        transform.position += x* speed * Time.deltaTime;
    }
}
