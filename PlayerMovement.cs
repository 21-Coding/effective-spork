using Systems.Collections;
using Systems.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;
    public float turnSpeed = 20f;
    Animator m_Animator;
    Rigidbody m_Rigidbody;
    void Start()
    {
         m_Animator = GetComponent<Animator> ();
         m_Rigidbody = GetComponent<Rigidbody> ();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");
        
        m_Movement.Set(horizontal, 0f, vertical);
        m_Movement.Normalize ();

         bool hasHorizontalInput = !Mathf.Approximately (horizontal, 0f);
         bool hasVerticalInput = !Mathf.Approximately (vertical, 0f);

         bool isWalking = hasHorizontalInput || hasVerticalInput;
         m_Animator.SetBool("IsWalking", isWalking);
    
        Vector3 desiredForward = Vector3.RotateTowards (transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
        m_Rotation = Quaternion.LookRotation (desiredForward);
    
    }

     void OnAnimatorMove ()
    {
          m_Rigidbody.MovePosition (m_Rigidbody.position + m_Movement * m_Animator.deltaPosition.magnitude);

    }


}