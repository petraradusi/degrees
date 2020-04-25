using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5.0f;


    private Rigidbody2D rigidbody;

    private Vector2 movement;
    

    // Start is called before the first frame update
    void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate() {
        this.rigidbody.MovePosition(rigidbody.position + movement * speed * Time.fixedDeltaTime);

     }

}
