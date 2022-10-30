using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Transform Firepoint;
    
    public Joystick joystick;
    public Joystick joystick2aim;

    Vector2 movement;
    Vector3 Lookdirection;
    float lookAngle;





    // Update is called once per frame
    void Update()
    {

        Lookdirection = new Vector3(joystick2aim.Horizontal,joystick2aim.Vertical,0);
        lookAngle = Mathf.Atan2(Lookdirection.y, Lookdirection.x) * Mathf.Rad2Deg;
        Firepoint.rotation = Quaternion.Euler(0, 0, lookAngle-90);

        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;
         
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
