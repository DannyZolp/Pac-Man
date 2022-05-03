using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody m_Rigidbody;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_Rigidbody.velocity = (transform.position + Vector3.forward);
        } else if (Input.GetKey(KeyCode.A))
        {
            m_Rigidbody.velocity = (transform.position + Vector3.left);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            m_Rigidbody.velocity = (transform.position + Vector3.back);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            m_Rigidbody.velocity = (transform.position + Vector3.right);
        }
    }
}
