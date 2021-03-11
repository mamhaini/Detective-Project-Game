using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator anim;
    public float playerSpeed = 5.0f;

    private CharacterController controller;
    private Vector3 playerVelocity;
   


    private void Start()
    {
        // Character Controller
        controller = gameObject.AddComponent<CharacterController>();
        controller.height = 0.1f;
        controller.radius = 0.1f;
        // Animator reference
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
        
      
        // Movement
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        // Movement and run animation condition
        if (move != Vector3.zero)
        {
            anim.SetInteger("Condition", 1);
            gameObject.transform.forward = move;
        }
        else
        {
            anim.SetInteger("Condition", 0);
        }


    }

}