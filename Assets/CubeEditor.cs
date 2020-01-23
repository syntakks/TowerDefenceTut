using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode] // Allows for script to be applied to editor without running game. 
[SelectionBase] // Makes it harder to select children when drag/drop by mistake. 
[RequireComponent(typeof(Waypoint))]
public class CubeEditor: MonoBehaviour
{
    Waypoint waypoint;

    void Awake()
    {
        waypoint = GetComponent<Waypoint>(); 
    }

    // Constrain the position of the block. 
    void Update()
    {
        SnapToGrid();
        UpdateLabel(); 
    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GetGridSize(); 
        transform.position = new Vector3(waypoint.GetGridPosition().x, 0f, waypoint.GetGridPosition().y);
    }

    private void UpdateLabel()
    {
        int gridSize = waypoint.GetGridSize();
        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        string positionText = (waypoint.GetGridPosition().x / gridSize) + "," + (waypoint.GetGridPosition().y / gridSize);
        textMesh.text = positionText;
        gameObject.name = positionText;
    }
}
