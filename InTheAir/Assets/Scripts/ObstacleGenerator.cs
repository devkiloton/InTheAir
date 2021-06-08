using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    private float timeToGen = 3;
    private float counter;
    [SerializeField]
    private GameObject obstacles;
    private void Start()
    {
        counter = timeToGen;
    }
    private void Update()
    {
        counter -= Time.deltaTime;
        if(counter < 0)
        {
            GameObject.Instantiate(obstacles, transform.position, Quaternion.identity);
            counter = timeToGen + Time.deltaTime;
        }
    }
}
