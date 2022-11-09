using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    [SerializeField]
    private TileData[] _tiles;

    private int _rows;
    private int _columns;

    // Start is called before the first frame update
    void Start()
    {
        _rows = 5;
        _columns = 5;
        InitializeTiles();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitializeTiles()
    {
        int xIter = 0;
        int yIter = 0;
        foreach (var tile in _tiles)
        {
            tile.SetCoordinates(xIter, yIter);
            if (xIter == _columns - 1)
            {
                xIter = 0;
                yIter++;
            }
            else
            {
                xIter++;
            }
        }
    }

    private TileData FindTile(int x, int y)
    {
        foreach (var tile in _tiles)
        {
            int[] c = tile.GetCoordinates();

            if (c[0] == x && c[1] == y)
            {
                return tile;
            }
        }

        return null;
    }

    public TileData[] GetTileNeighbors(TileData tile)
    {
        TileData[] neighbors = new TileData[4];
        int[] c = tile.GetCoordinates();

        //Get North neighbor
        if (FindTile(c[0] + 1, c[1]) != null)
        {
            neighbors[0] = FindTile(c[0] + 1, c[1]);
        }

        //Get South neighbor
        if (FindTile(c[0] - 1, c[1]) != null)
        {
            neighbors[1] = FindTile(c[0] - 1, c[1]);
        }

        //Get East neighbor
        if (FindTile(c[0], c[1] - 1) != null)
        {
            neighbors[2] = FindTile(c[0], c[1] - 1);
        }

        //Get West neighbor
        if (FindTile(c[0], c[1] + 1) != null)
        {
            neighbors[3] = FindTile(c[0], c[1] + 1);
        }

        return neighbors;

    }
}
