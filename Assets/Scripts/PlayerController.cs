using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    private int speed = 20;
    private int force = 10;
    public Rigidbody rb;

    private bool onIsland;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * speed * horizontal);

        if (Input.GetKeyDown(KeyCode.Space)&&onIsland==true )
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            onIsland = false;
        }

        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Island"))
        {
            onIsland = true;
        }
    }
}
