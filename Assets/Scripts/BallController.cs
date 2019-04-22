using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public GameObject youWinText;
    public AudioSource pointAudio;
    public AudioSource wonAudio;
    public AudioSource collisionAudio;

    [Range(1, 5)]
    public float speed;

    private int points = 0;
    private Rigidbody rigidbody;

    // Start is called before the first frame update
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
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Pickup>().PickUp();
        points++;

        pointAudio.Play();

        pointsText.text = points + " Points";

        if (points == 10)
        {
            wonAudio.Play();
            youWinText.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        collisionAudio.Play();
    }
}
