using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField]
    private float velocity = 0.01f;
    private void Update()
    {
        transform.Translate(Vector2.left*velocity);
    }
}
