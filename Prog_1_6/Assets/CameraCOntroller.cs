using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCOntroller : MonoBehaviour
{
    private float MouseX;
    private float MouseY;
    public float secivity = 200.0f;
    public Transform capsula;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        MouseX = Input.GetAxis("Mouse X") * secivity * Time.deltaTime;
        MouseY = Input.GetAxis("Mouse Y") * secivity * Time.deltaTime;

        capsula.Rotate(MouseX * new Vector3(0, 1, 0));
        transform.Rotate(-MouseY * new Vector3(1, 0, 0));
    }
}
