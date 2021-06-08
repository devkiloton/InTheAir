using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    private Rigidbody2D plane;
    [SerializeField]
    private float impulseForceBelowPlane = 8;

    private void Awake()
    {
        plane = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            planeImpúlse();
        }
    }
    private void planeImpúlse()
    {
        plane.AddForce(Vector2.up * impulseForceBelowPlane, ForceMode2D.Impulse);   
    }
}
