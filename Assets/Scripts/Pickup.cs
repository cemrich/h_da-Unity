using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public GameObject objectToHide;
    public Vector3 rotation;

    public void PickUp()
    {
        particleSystem.Play();
        objectToHide.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation);
    }
}
