using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.TerrainAPI;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public GameObject ViewCamera = null;
    public AudioClip CoinSound = null;

  
    private Rigidbody mRigidBody = null;
    private AudioSource mAudioSource = null;
    private const double V = 1.57;
    private const double C = 3.31;
    private float CameraUp = (float)V;
    private float CameraBack = (float)C;

    // Start is called before the first frame update
    void Start()
    {
        mRigidBody = GetComponent<Rigidbody>();
        mAudioSource = GetComponent<AudioSource>();
    }
    //Camera Follows Player 
    void FixedUpdate()
    {
        if (ViewCamera != null)
        {
            Vector3 direction = (Vector3.up * CameraUp + Vector3.back) * CameraBack;
            {
 
                ViewCamera.transform.position = transform.position + direction;
       
            }
                 ViewCamera.transform.LookAt(transform.position);
        }
    }
    // Sound gets played when player picks up a coin
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Coin"))
        {
            if (mAudioSource != null && CoinSound != null)
            {
                mAudioSource.PlayOneShot(CoinSound);
            }
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
