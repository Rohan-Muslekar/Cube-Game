using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
public PlayerMovement movement;

void OnCollisionEnter(Collision collinfo){
    if (collinfo.collider.tag == "Obstacle"){
        movement.enabled = false;
        FindObjectOfType<GMScript>().EndGame();
    }
}

}
