using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMove movement; //This creates a reference for the PlayerMove scropt

    void OnCollisionEnter(Collision collisionInfo) //collisionInfo is the variable name for the collision we hit
    {
        if(collisionInfo.collider.tag == "Obstacle") //displays the collider we hit and the object that it belongs to
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
