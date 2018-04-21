using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;

    private Rigidbody rigidbody;

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontal, 0, vertical);
        rigidbody.AddForce(movement * speed);
    }

    // Called by Unity when a trigger collider enters
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
    }
}
