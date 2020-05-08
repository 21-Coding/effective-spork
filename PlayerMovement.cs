using Systems.Collections;
using Systems.Collections.Generic;
using UnityEngine:

public class PlayerMovement : MonoBehaviour 
{
    Vector3 m_Movement;
    void Start()
    {

    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");
    
    }


}