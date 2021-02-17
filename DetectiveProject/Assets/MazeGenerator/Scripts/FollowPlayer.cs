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

    // public GameObject player;
    // private Vector3 offset = new Vector3(0, 7, -13);

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
            Vector3 direction = (Vector3.up * 2 + Vector3.back) * 2;
            RaycastHit hit;
            Debug.DrawLine(transform.position, transform.position + direction, Color.red);
            if (Physics.Linecast(transform.position, transform.position + direction, out hit))
            {
                ViewCamera.transform.position = hit.point;
            }
            else
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
        // Offset the camera behind the player 
        
        // transform.position = player.transform.position + offset;
    }
}
