using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody _rb;
    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;

    //UNITY PHYSICS is prefered in FixedUpdate instead of Update() or Start()
    void FixedUpdate()
    {
        //Add a forward force to the cube
        _rb.AddForce(0, 0, forwardForce * Time.deltaTime);  

        if( Input.GetKey("d")) //If statements are only executed if the condition is met in the parentheses
        {
            _rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            _rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(_rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
