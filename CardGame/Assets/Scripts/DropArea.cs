using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropArea : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log(eventData + " dropped");
        
        DragElement d = eventData.pointerDrag.GetComponent<DragElement>();

        TileManager tm = FindObjectOfType<TileManager>();
        TileData td = GetComponent<TileData>();

        if (td._hasEnemy == false)
        {
            CardData cardData = eventData.pointerDrag.GetComponent<CardData>();

            TileData northTile = tm.GetTileNeighborByDirection(td, "NORTH");
            if (northTile != null)
            {
                EnemyData northEnemy = northTile.enemyData;
                northEnemy.TakeDamage(cardData.topValue, "NORTH");
            }

            TileData southTile = tm.GetTileNeighborByDirection(td, "SOUTH");
            if (southTile != null)
            {
                EnemyData southEnemy = southTile.enemyData;
                southEnemy.TakeDamage(cardData.bottomValue, "SOUTH");
            }

            TileData eastTile = tm.GetTileNeighborByDirection(td, "EAST");
            if (eastTile != null)
            {
                EnemyData eastEnemy = eastTile.enemyData;
                eastEnemy.TakeDamage(cardData.rightValue, "EAST");
            }

            TileData westTile = tm.GetTileNeighborByDirection(td, "WEST");
            if (westTile != null)
            {
                EnemyData westEnemy = westTile.enemyData;
                westEnemy.TakeDamage(cardData.leftValue, "WEST");
            }

            if (d != null)
            {
                d._parentReturn = this.transform;
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Entering area");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("Leaving area");
    }
}
