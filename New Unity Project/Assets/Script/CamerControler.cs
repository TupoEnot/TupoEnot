using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerControler : MonoBehaviour
{
    private float mouseX;
    private float mouseY;

    [Header("Чувствительность мыши")]
    public float senstivityMouse = 200f;

    public Transform cubek;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * senstivityMouse * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * senstivityMouse * Time.deltaTime;

        cubek.Rotate(mouseX * new Vector3(0, 1, 0));

        transform.Rotate(-mouseY * new Vector3(1, 0, 0));
    }
}
