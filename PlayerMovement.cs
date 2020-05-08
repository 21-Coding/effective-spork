using Systems.Collections;
using Systems.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    Vector3 m_Movement;
    Animator m_Animator;
    void Start()
    {
         m_Animator = GetComponent<Animator> ();
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
    
    }


}