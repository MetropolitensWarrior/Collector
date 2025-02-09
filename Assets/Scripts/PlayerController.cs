using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    public int speed = 10;
    public int speedRotate = 30;
    public int force = 10;
    private Rigidbody rb;

    public bool onIsland;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * speedRotate * horizontal);

        if (Input.GetKeyDown(KeyCode.Space) && onIsland)
        {
            rb.AddForce(Vector3.up * force, ForceMode.VelocityChange);
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
