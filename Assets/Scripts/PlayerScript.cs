using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public Vector2 speed = new Vector2(50, 50);

    private Vector3 movement;

    void Update()
    {
        movement = new Vector2(speed.x * Input.GetAxis("Horizontal"),
                               speed.y * Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        rigidbody2D.velocity = movement;
    }
}
