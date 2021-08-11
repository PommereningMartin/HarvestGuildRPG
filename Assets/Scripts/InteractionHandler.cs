using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class InteractionHandler : MonoBehaviour
{

    public Grid grid;
    public Tilemap interactableTileMap;

    private Tile[] tilesToDelete;

    public Tile tileToBeSet;

    public Text tilePosition;

    public Text tileName;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int coordinate = grid.WorldToCell(pos);
            tilePosition.text = "Tile Position: " + coordinate.ToString();
            var test = interactableTileMap.GetTile(coordinate);
            tileName.text = "Tile Name: " + test.name.ToString();
            if ("Overworld_0".Equals(test.name))
            {
                interactableTileMap.SetTile(coordinate, tileToBeSet);
            }
        }
    }
}
