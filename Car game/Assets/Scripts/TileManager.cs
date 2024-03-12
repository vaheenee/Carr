using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class TileManager : MonoBehaviour
{
    public PathCreator pathCreator;
    public GameObject tilePrefab;
    public float spacing = 1f;

    // Start is called before the first frame update
    void Start()
    {
        if (pathCreator == null || tilePrefab == null)
        {
            Debug.LogError("Path Creator or Tile Prefab not assigned!");
            return;
        }

        GenerateTilesAlongPath();
    }

    // Generate tiles along the path
    void GenerateTilesAlongPath()
    {
        float distanceTravelled = 0f;

        while (distanceTravelled < pathCreator.path.length)
        {
            // Get the position and rotation on the path
            Vector3 position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            Quaternion rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);

            // Instantiate the tile prefab
            GameObject tile = Instantiate(tilePrefab, position, rotation);
            tile.transform.SetParent(transform); // Set the tile's parent to this manager object

            // Move forward along the path by the spacing
            distanceTravelled += spacing;
        }
    }
}
