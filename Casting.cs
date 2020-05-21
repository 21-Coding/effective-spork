using UnityEngine;
using Sytem.Collections;

public class Casting : MonoBehaviour {
    public float TargetDistance:

    void Update() {
        RaycastHit TheHit;

        if(Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out TheHit)) {

            
        }
        
    }

}