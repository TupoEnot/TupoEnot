using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_Script : MonoBehaviour
{
  
    private Transform m_Transform;
    // Start is called before the first frame update
    void Start()
    {
      m_Transform = GetComponent<Transform>();  
    }

    // Update is called once per frame
    void Update()
    {
       var directionVertical = m_Transform.forward * Input.GetAxisRaw("Vertical");
        var directoinHorizontal = m_Transform.right * Input.GetAxisRaw("Horizontal");
        m_Transform.position += (directionVertical + directoinHorizontal) * 10.0f * Time.deltaTime;
        
    }
}
