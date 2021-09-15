 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float spd = 3;
    public float jump = 6;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float vspd = Input.GetAxis("Horizontal");
        transform.position += new Vector3(vspd, 0, 0) * Time.deltaTime * spd;

        rb.freezeRotation = true; //Freezes the z-axis.

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
    }
}
