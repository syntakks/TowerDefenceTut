using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    const int gridSize = 10;
    Vector2Int gridPosition;

    public Vector2 GetGridPosition()
    {
        return new Vector2Int(
        Mathf.RoundToInt(transform.position.x / gridSize) * gridSize,
        Mathf.RoundToInt(transform.position.z / gridSize) * gridSize
        ); 
    }

    public int GetGridSize()
    {
        return gridSize; 
    }
}
