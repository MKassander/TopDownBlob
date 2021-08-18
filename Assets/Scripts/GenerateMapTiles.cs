using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMapTiles : MonoBehaviour
{
    public GameObject[] tiles;

    public int total;
    public int lineBreakNum;
    private Vector2 TilePlacement;
    void Start()
    {
        var linebreak = lineBreakNum;
        for (int i = 0; i < total; i++)
        {
            var chosen = Random.Range(0, tiles.Length);
            var tile = Instantiate(tiles[chosen]);
            tile.transform.position = new Vector3(TilePlacement.x, 0, TilePlacement.y);
            TilePlacement.x += 30;
            if (i == linebreak -1)
            {
                TilePlacement.x = 0;
                TilePlacement.y += 30;
                linebreak += lineBreakNum;
            }
        }
    }
}
