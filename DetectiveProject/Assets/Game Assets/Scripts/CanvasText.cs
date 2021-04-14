using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasText : MonoBehaviour
{
    // Canvas that appears when the game has not started 
    public Canvas canvas;


    // Start is called before the first frame update
    void Start()
    {
        //Canvas gets dissabled upon play
        canvas = canvas.GetComponent<Canvas>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
