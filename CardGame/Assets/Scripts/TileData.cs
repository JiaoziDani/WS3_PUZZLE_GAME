using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileData : MonoBehaviour
{
    [SerializeField]
    private int _xCoord;
    [SerializeField]
    private int _yCoord;

    public bool _hasEnemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[] GetCoordinates()
    {
        int[] c = new int[] { _xCoord, _yCoord };
        return c;
    }

    public void SetCoordinates(int x, int y)
    {
        _xCoord = x;
        _yCoord = y;
    }

    public void DebugTest()
    {
        Debug.Log("Howdy neighbor. This is " + _xCoord.ToString() + "," + _yCoord.ToString());
    }

    public void DamageTile(CardData cardData)
    {

    }
   
}

