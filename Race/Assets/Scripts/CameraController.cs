using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    public float turnSpeed;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }
        transform.position = player.transform.position + offset;
    }
}