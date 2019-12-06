using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float force = 100.0f;
    public float sideforce = 20.0f;
    public float up = 500;
    public int count = 0;
    public Transform player;
    public PlayerMovement movement;
    void Start()
    {
        rb.useGravity = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3(0,0,Input.GetAxis("Vertical"));
        rb.AddForce(vec * force * Time.deltaTime,ForceMode.VelocityChange);
        vec = new Vector3(Input.GetAxis("Horizontal"),0,0);
        rb.AddForce(vec * sideforce * Time.deltaTime,ForceMode.VelocityChange);
        
          if (Input.GetKeyDown("space")){
            count += 1;
            if(count >= 2){
                Debug.Log("Movement Disabled");
                movement.enabled = false;
            }
            vec = new Vector3(0,100,0);
            rb.AddForce(0,up,0);
        }

        

        if (rb.position.y < -1.0f){
            FindObjectOfType<GMScript>().EndGame();
        }
        
    }
    void OnCollisionEnter(Collision collinfo){
    if (collinfo.collider.tag == "grd"){
        movement.enabled = true;
        count = 0;
    }
    }
}
