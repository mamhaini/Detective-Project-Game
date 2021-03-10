using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    public float playerSpeed = 5.0f;


    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        controller.height = 0.1f;
        controller.radius = 0.1f;
    }

    void Update()
    {
      
        if ( playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }


    }

}