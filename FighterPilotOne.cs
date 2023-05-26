using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterPilotOne : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(xMove, zMove) * moveSpeed;
    }
}
