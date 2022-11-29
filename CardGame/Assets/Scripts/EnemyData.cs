using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyData : MonoBehaviour
{
    [SerializeField]
    SOEnemy scriptableObjectEnemy;
    [SerializeField]
    Image enemyArt;

    CardData cd;

    private void Awake()
    {
        if(scriptableObjectEnemy != null)
        {
            enemyArt.sprite = scriptableObjectEnemy.art;
            cd = GetComponent<CardData>();
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
        cd.topValue = scriptableObjectEnemy.topHealth;
        cd.bottomValue = scriptableObjectEnemy.bottommHealth;
        cd.leftValue = scriptableObjectEnemy.leftHealth;
        cd.rightValue = scriptableObjectEnemy.rightHealth;
    }

    // Update is called once per frame
    void Update()
    {
        enemyArt.sprite = scriptableObjectEnemy.art;
        cd = GetComponent<CardData>();
    }

   public void SetScriptableObject(SOEnemy enemy)
    {
        scriptableObjectEnemy = enemy;
        enemyArt.sprite = scriptableObjectEnemy.art;
        cd = GetComponent<CardData>();
    }

    public void TakeDamage(int damage, string direction)
    {
        if (direction == "NORTH")
        {
            cd.bottomValue -= damage;
        }
        else if (direction == "SOUTH")
        {
            cd.topValue -= damage;
        }
        else if (direction == "EAST")
        {
            cd.leftValue -= damage;
        }
        else if (direction == "WEST")
        {
            cd.rightValue -= damage;
        }
    }
}
