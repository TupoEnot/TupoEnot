using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class cubek : MonoBehaviour
{
    [Header("�������� ��������")]
    public float speed = 7f;
    [Header("�������� �������� �����")]
    public float speedBack = 4f;
    [Header("�������� �������� �����")]
    public float jumpPower = 200f;
    [Header("�� �� �����?")]
    public bool ground;

    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        GetInput();
    }


    private void GetInput()
    {
       
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speedBack * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ground == true)
            {
                rb.AddForce(transform.up * jumpPower);
            }
        }
        
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            ground = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = false;
        }
    }
}
