using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public GameObject cam;
    Rigidbody rb;
    public float speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Horizontal");

        MoveCharacter(horizontal,vertical);
    }

    void MoveCharacter(float horizontal,float vertical)
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 direction = (rb.transform.position - cam.transform.position).normalized;
            direction.y = 0.0f;
            direction.Scale(new Vector3(speed, speed, speed));
            rb.AddForce(direction);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 direction = (cam.transform.position - rb.transform.position).normalized;
            direction.y = 0.0f;
            direction.Scale(new Vector3(speed, speed, speed));
            rb.AddForce(direction);
        }

    }
}