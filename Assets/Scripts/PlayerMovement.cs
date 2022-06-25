using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] VisualEffect smokePoof;
    
    [SerializeField]
    Vector3 v3Force;

    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;

    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3Force;
            smokePoof.Play();

        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Force;
            smokePoof.Play();
    }
}
