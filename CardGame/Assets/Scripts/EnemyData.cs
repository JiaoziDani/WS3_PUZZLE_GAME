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

    private void Awake()
    {
        enemyArt.sprite = scriptableObjectEnemy.art;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
