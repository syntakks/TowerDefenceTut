using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private List<Waypoint> path;
    [SerializeField] private float moveDelaySeconds = 1f; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FollowPath()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FollowPath()
    {
        print("Starting patrol"); 
        foreach (Waypoint waypoint in path)
        {
            print("Visiting waypoint: " + waypoint.name);
            transform.position = waypoint.transform.position; 
            yield return new WaitForSeconds(moveDelaySeconds); 
        }
        print("Patrol Ended"); 
    }
}
