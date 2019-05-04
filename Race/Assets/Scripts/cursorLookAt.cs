using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorLookAt : MonoBehaviour
{
    public bool showCursor = true;
    public float Sensitivity = 1;
    private float oldRotX;
    private float oldRotY;
    [Range(-1, 1)] [SerializeField] private int invert;
    // Start is called before the first frame update
    void Start()
    {
        oldRotX = transform.localEulerAngles.x;
        oldRotY = transform.localEulerAngles.y;
        if (showCursor == false)
        {
            Cursor.visible = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            float newRotY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * Sensitivity * invert;
            float newRotX = transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * Sensitivity * invert;
            gameObject.transform.localEulerAngles = new Vector3(newRotX, newRotY, 0);
        }
        else if (Input.GetKey(KeyCode.Y))
        {
            gameObject.transform.localEulerAngles = new Vector3(oldRotX, oldRotY, 0);

        }
    }
}

