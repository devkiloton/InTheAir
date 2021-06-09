using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    private Rigidbody2D plane;
    [SerializeField]
    private float impulseForceBelowPlane = 8;
    private EndGame endingGame;

    private void Awake()
    {
        plane = GetComponent<Rigidbody2D>();
        endingGame = GetComponent<EndGame>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            planeImpulse();
        }
    }
    private void planeImpulse()
    {
        plane.velocity = Vector2.zero;
        plane.AddForce(Vector2.up * impulseForceBelowPlane, ForceMode2D.Impulse);   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        endingGame.PauseScene();
    }
}
