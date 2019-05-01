using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public GameObject camera;
    Rigidbody rigidbody;
    public float speed;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Horizontal");

        MoveCharacter(horizontal,vertical);
    }

    void MoveCharacter(float horizontal,float vertical)
    {
        //movement.Set(horizontal, 0, vertical);
        //if (horizontal != 0 || vertical != 0)
        //{
        //   rigidbody.MoveRotation(Quaternion.LookRotation(movement));
        //}
        //movement = movement.normalized * movementSpeed * Time.deltaTime;
        //rigidbody.MovePosition(transform.position + movement);
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 direction = (rigidbody.transform.position - camera.transform.position).normalized;
            direction.y = 0.0f;
            direction.Scale(new Vector3(speed, speed, speed));
            rigidbody.AddForce(direction);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 direction = (camera.transform.position - rigidbody.transform.position).normalized;
            direction.y = 0.0f;
            direction.Scale(new Vector3(speed, speed, speed));
            rigidbody.AddForce(direction);
        }

    }
}